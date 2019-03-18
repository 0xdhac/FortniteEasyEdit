// dllmain.cpp : Defines the entry point for the DLL application.
#include "stdafx.h"
#include "Mouse.h"
#include "Keyboard.h"
#include "Config.h"
#include "Binds.h"
#include <fstream>

enum BuildType
{
	Build_Floor,
	Build_Stair,
	Build_Cone,
	Build_Wall
};

enum LastKeyType
{
	Key_None,
	Key_Build,
	Key_Weapon
};

#define KEY_WALL VK_XBUTTON2
#define KEY_FLOOR 'Q'
#define KEY_STAIR 'C'
#define KEY_CONE VK_XBUTTON1

bool g_IsGameUp           = false;
unsigned int g_LastWeapon = -1;
unsigned int g_LastBuild  = -1;
LastKeyType g_LastKeyType = Key_None;
Bind* g_FakeEditBind;
Bind* g_RealEditBind;
Bind* g_FakeCrouchBind;
Bind* g_RealCrouchBind;
Bind* g_WallRetakeBind;
Bind* g_ShotgunBind;
Bind* g_UseBind;
Bind* g_FireBind;
Bind* g_ADSBind;
Bind* g_PlaceBuildingBind;
Bind* g_EditResetBind;
Bind* g_JumpBind;

Bind* g_BuildList[4];
Bind* g_WeaponList[6];

HHOOK hMouseHook;
HHOOK hKeyboardHook;

LRESULT CALLBACK mouseProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	if (nCode >= 0)
	{
		switch (wParam)
		{
		case WM_LBUTTONDOWN:
			FindAndSetKeyDownOnBind(WH_MOUSE_LL, WM_LBUTTONDOWN);
			break;

		case WM_LBUTTONUP:
			FindAndSetKeyUpOnBind(WH_MOUSE_LL, WM_LBUTTONDOWN);
			break;

		case WM_RBUTTONDOWN:
			FindAndSetKeyDownOnBind(WH_MOUSE_LL, WM_RBUTTONDOWN);
			break;

		case WM_RBUTTONUP:
			FindAndSetKeyUpOnBind(WH_MOUSE_LL, WM_RBUTTONDOWN);
			break;

		case WM_MOUSEWHEEL:
			int zDelta = GET_WHEEL_DELTA_WPARAM(wParam);
			if (zDelta > 0)
			{
				FindAndSetKeyDownOnBind(WH_MOUSE_LL, WM_MOUSEWHEEL, 0xff);
			}
			else if (zDelta < 0)
			{
				FindAndSetKeyDownOnBind(WH_MOUSE_LL, WM_MOUSEWHEEL, 0xfe);
			}
			break;
		}
	}

	return CallNextHookEx(hMouseHook, nCode, wParam, lParam);
}

LRESULT CALLBACK keyboardProc(int nCode, WPARAM wParam, LPARAM lParam)
{
	switch (wParam)
	{
	case WM_KEYDOWN:
	{
		KBDLLHOOKSTRUCT k = *(LPKBDLLHOOKSTRUCT)lParam;
		FindAndSetKeyDownOnBind(WH_KEYBOARD_LL, WM_KEYDOWN, k.vkCode);
		break;
	}
	case WM_KEYUP:
	{
		KBDLLHOOKSTRUCT k = *(LPKBDLLHOOKSTRUCT)lParam;
		FindAndSetKeyUpOnBind(WH_KEYBOARD_LL, WM_KEYDOWN, k.vkCode);
		break;
	}
	}

	return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
}

extern "C"
{
	DllExport void InitConfig()
	{
		g_FakeEditBind = RegisterBind("FakeEdit", "Fake Edit Key", WH_KEYBOARD_LL, WM_KEYDOWN, VK_LSHIFT, "The button you will physically press to start editing a structure.");
		g_RealEditBind = RegisterBind("RealEdit", "Real Edit Key", WH_KEYBOARD_LL, WM_KEYDOWN, 'L', "The button that is actually bound to edit structures in-game.");
		g_FakeCrouchBind = RegisterBind("FakeCrouch", "Fake Crouch Key", WH_KEYBOARD_LL, WM_KEYDOWN, VK_LCONTROL, "The button you will physically press to crouch.");
		g_RealCrouchBind = RegisterBind("RealCrouch", "Real Crouch Key", WH_KEYBOARD_LL, WM_KEYDOWN, 'U', "The button that is actually bound to crouch in-game.");
		g_FireBind = RegisterBind("Fire", "Fire Key", WH_MOUSE_LL, WM_LBUTTONDOWN, VK_LBUTTON);
		g_PlaceBuildingBind = RegisterBind("Place", "Place Building Key", WH_MOUSE_LL, WM_LBUTTONDOWN, VK_LBUTTON);
		g_ADSBind = RegisterBind("ADS", "ADS Key", WH_MOUSE_LL, WM_RBUTTONDOWN, VK_RBUTTON);
		g_UseBind = RegisterBind("Use", "Use Key", WH_KEYBOARD_LL, WM_KEYDOWN, 'E');
		g_EditResetBind = RegisterBind("EditReset", "Edit Reset Key", WH_MOUSE_LL, WM_RBUTTONDOWN, VK_RBUTTON);
		g_JumpBind = RegisterBind("Jump", "Jump Key", WH_MOUSE_LL, WM_MOUSEWHEEL, 0xff);
		g_WallRetakeBind = RegisterBind("WallRetake", "Wall Retake Key", WH_KEYBOARD_LL, WM_KEYDOWN, 'G', "This key is used to wake enemy walls by attacking the structure and then placing your own wall before the enemy can.");
		g_ShotgunBind = RegisterBind("Shotgun", "Shotgun Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '3', "The macro will press this key when you finish editing a structure so that you don't have to do it by yourself.");
		g_BuildList[Build_Floor] = RegisterBind("Floor", "Floor Key", WH_KEYBOARD_LL, WM_KEYDOWN, 'Q');
		g_BuildList[Build_Stair] = RegisterBind("Stair", "Stair Key", WH_KEYBOARD_LL, WM_KEYDOWN, 'C');
		g_BuildList[Build_Cone] = RegisterBind("Cone", "Cone Key", WH_KEYBOARD_LL, WM_KEYDOWN, VK_XBUTTON1);
		g_BuildList[Build_Wall] = RegisterBind("Wall", "Wall Key", WH_KEYBOARD_LL, WM_KEYDOWN, VK_XBUTTON2);
		g_WeaponList[0] = RegisterBind("Weapon0", "Pickaxe Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '1');
		g_WeaponList[1] = RegisterBind("Weapon1", "Weapon 1 Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '2');
		g_WeaponList[2] = RegisterBind("Weapon2", "Weapon 2 Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '3');
		g_WeaponList[3] = RegisterBind("Weapon3", "Weapon 3 Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '4');
		g_WeaponList[4] = RegisterBind("Weapon4", "Weapon 4 Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '5');
		g_WeaponList[5] = RegisterBind("Weapon5", "Weapon 5 Pullout Key", WH_KEYBOARD_LL, WM_KEYDOWN, '6');

		Config::InitJson("config.cfg");

		hMouseHook    = SetWindowsHookEx(WH_MOUSE_LL, mouseProc, NULL, 0);
		hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, keyboardProc, NULL, 0);
	}

	DllExport int GetBindCount()
	{
		return BindList.size();
	}

	DllExport int GetBind(int bind, char* name, char* displayname, char* description)
	{
		strcpy_s(name, BindList.at(bind)->m_Name.length() + 1, BindList.at(bind)->m_Name.c_str());
		strcpy_s(displayname, BindList.at(bind)->m_DisplayName.length() + 1, BindList.at(bind)->m_DisplayName.c_str());
		strcpy_s(description, BindList.at(bind)->m_Description.length() + 1, BindList.at(bind)->m_Description.c_str());
		return BindList.at(bind)->m_vkCode;
	}

	DllExport bool SetBind(char* bind, int vkCode)
	{
		for (Bind* b : BindList)
		{
			if (b->m_Name.compare(std::string(bind)) == 0)
			{
				UpdateBindKeyCode(std::string(bind), vkCode);
				return true;
			}
		}

		return false;
	}

	DllExport void EditT()
	{
		srand(time(NULL));
		bool bIsEditKeyPressed = false;

		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsEditKeyPressed == false && GetBindKeyDown(g_FakeEditBind))
				{
					bIsEditKeyPressed = true;

					if (g_LastKeyType == Key_Build && g_LastWeapon != -1)
					{
						Keyboard::PressKey(g_WeaponList[g_LastWeapon], (rand() % 10) + 10);
						Sleep((rand() % 10) + 10);
					}

					Keyboard::PressKey(g_RealEditBind, (rand() % 15) + 15); // Start edit
					Sleep((rand() % 10) + 10); // Wait 10(+ 0-10)ms to allow edit reset
					Keyboard::PressKey(g_EditResetBind, (rand() % 15) + 8);
				}

				if (bIsEditKeyPressed == true && !GetBindKeyDown(g_FakeEditBind))
				{
					bIsEditKeyPressed = false;

					Keyboard::PressKey(g_RealEditBind, (rand() % 15) + 15); // End edit
					Sleep(rand() % 20); // Wait 0-20ms to pull out shotgun
					Keyboard::PressKey(g_ShotgunBind, (rand() % 15) + 15); // Pull out shotgun
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}

	DllExport void WallReplaceT()
	{
		srand(time(NULL));
		bool bIsRetakeKeyPressed = false;
		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsRetakeKeyPressed == false && GetBindKeyDown(g_WallRetakeBind))
				{
					bIsRetakeKeyPressed = true;
					DWORD structureKey = g_BuildList[Build_Wall]->m_vkCode;

					Keyboard::PressKey(g_FireBind, 0);

					if (g_LastWeapon == 0) // Pickaxe swing has a delay, 165ms is perfect
						Sleep(165);
					Sleep(7);

					Keyboard::HoldKey(structureKey);

					for (int i = 0; i < 20; i++) // Spam the structure place button
					{
						Keyboard::PressKey(g_PlaceBuildingBind, 0);
						Sleep(10);
					}

					Sleep(rand() % 20);

					Keyboard::ReleaseKey(structureKey);

					Sleep(10);

					Keyboard::PressKey(g_WeaponList[g_LastWeapon], rand() % 10 + 10);
				}
				else if (bIsRetakeKeyPressed == true && !GetBindKeyDown(g_WallRetakeBind))
				{
					bIsRetakeKeyPressed = false;
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}

	DllExport void CrouchT()
	{
		srand(time(NULL));
		bool bIsCrouchKeyPressed = false;

		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsCrouchKeyPressed == false && GetBindKeyDown(g_FakeCrouchBind))
				{
					bIsCrouchKeyPressed = true;

					Keyboard::PressKey(g_RealCrouchBind, (rand() % 15) + 15); // Start crouch
				}

				if (bIsCrouchKeyPressed == true && !GetBindKeyDown(g_FakeCrouchBind))
				{
					bIsCrouchKeyPressed = false;

					Keyboard::PressKey(g_RealCrouchBind, (rand() % 15) + 15); // End crouch
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}

	DllExport void CheckForegroundT()
	{
		while (true)
		{
			#ifdef NDEBUG
			if (IsDebuggerPresent())
			{
				g_IsGameUp = false;
				return;
			}
			#endif
				
			HWND fw = GetForegroundWindow();
			char sTitle[64];
			GetWindowTextA(fw, sTitle, sizeof(sTitle));
			
			g_IsGameUp = std::string(sTitle).find("Fortnite") == 0;

			Sleep(1000);
		}
	}

	DllExport void UpdateLastKeysT()
	{
		while (true)
		{
			if (g_IsGameUp)
			{
				for (int i = 0; i < 4; i++)
				{
					if (GetBindKeyDown(g_BuildList[i]))
					{
						g_LastBuild   = i;
						g_LastKeyType = Key_Build;
					}
				}

				for (int i = 0; i < 6; i++)
				{
					if (GetBindKeyDown(g_WeaponList[i]))
					{
						g_LastWeapon  = i;
						g_LastKeyType = Key_Weapon;
					}
				}

				Sleep(1);
			}
			else
			{
				Sleep(100);
			}
		}
	}
}
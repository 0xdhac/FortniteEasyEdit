// dllmain.cpp : Defines the entry point for the DLL application.
#include "stdafx.h"
#include "Mouse.h"
#include "Keyboard.h"

bool g_IsGameUp           = false;
unsigned int g_LastWeapon = -1;
unsigned int g_LastBuild  = -1;

#define KEY_WALL VK_XBUTTON2
#define KEY_FLOOR 'Q'
#define KEY_STAIR 'C'
#define KEY_CONE VK_XBUTTON1

enum BuildType
{
	Build_Floor,
	Build_Stair,
	Build_Cone,
	Build_Wall
};

int g_BuildList[] =
{
	KEY_FLOOR, KEY_STAIR, KEY_CONE, KEY_WALL
};

int g_WeaponList[] =
{
	'1', '2', '3', '4', '5', '6'
};

int g_FakeEditBind   = VK_LSHIFT;
int g_RealEditBind   = 'L';
int g_WallRetakeBind = 'G';
int g_ShotgunBind    = '3';


#include <fstream>
extern "C"
{
	DllExport void SetWeaponHotkey(int index, int vk)
	{
		g_WeaponList[index] = vk;
	}

	DllExport int GetWeaponHotkey(int index)
	{
		return g_WeaponList[index];
	}

	DllExport void SetBuildHotkey(int index, int vk)
	{
		g_BuildList[index] = vk;
	}

	DllExport int GetBuildHotkey(int index)
	{
		return g_BuildList[index];
	}

	DllExport void SetFakeEditHotkey(int vk)
	{
		g_FakeEditBind = vk;
	}

	DllExport int GetFakeEditHotkey()
	{
		return g_FakeEditBind;
	}

	DllExport void SetRealEditHotkey(int vk)
	{
		g_RealEditBind = vk;
	}

	DllExport int GetRealEditHotkey()
	{
		return g_RealEditBind;
	}

	DllExport void SetWallRetakeHotkey(int vk)
	{
		g_WallRetakeBind = vk;
	}

	DllExport int GetWallRetakeHotkey()
	{
		return g_WallRetakeBind;
	}

	DllExport void SetShotgunHotkey(int vk)
	{
		g_ShotgunBind = vk;
	}

	DllExport int GetShotgunHotkey()
	{
		return g_ShotgunBind;
	}

	DllExport void EditT()
	{
		srand(time(NULL));
		bool bIsEditKeyPressed = false;

		while (true)
		{
			if (g_IsGameUp)
			{
				if (bIsEditKeyPressed == false && GetAsyncKeyState(g_FakeEditBind))
				{
					bIsEditKeyPressed = true;

					Keyboard::PressKey(g_RealEditBind, (rand() % 15) + 15); // Start edit
					Sleep((rand() % 10) + 10); // Wait 10(+ 0-10)ms to allow edit reset
					Mouse::RightClick(0); // Edit reset
				}

				if (bIsEditKeyPressed == true && !GetAsyncKeyState(g_FakeEditBind))
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
				if (bIsRetakeKeyPressed == false && GetAsyncKeyState(g_WallRetakeBind))
				{
					bIsRetakeKeyPressed = true;
					DWORD structureKey = g_BuildList[Build_Wall];

					Mouse::LeftClick(0);

					if (g_LastWeapon == 0) // Pickaxe swing has a delay, 165ms is perfect
						Sleep(165);

					Keyboard::HoldKey(structureKey);

					for (int i = 0; i < 20; i++) // Spam the structure place button
					{
						Mouse::LeftClick(0);
						Sleep(10);
					}

					Sleep(rand() % 20);

					Keyboard::ReleaseKey(structureKey);

					Sleep(10);

					Keyboard::PressKey(g_WeaponList[g_LastWeapon], rand() % 10 + 10);
				}
				else if (bIsRetakeKeyPressed == true && !GetAsyncKeyState(g_WallRetakeBind))
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

	DllExport void CheckForegroundT()
	{
		while (true)
		{
			HWND fw = GetForegroundWindow();
			char sTitle[64];

			GetWindowTextA(fw, sTitle, sizeof(sTitle));

			g_IsGameUp = (sTitle[0] == 'F' && sTitle[1] == 'o');

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
					if (GetAsyncKeyState(g_BuildList[i]))
					{
						g_LastBuild = i;
					}
				}

				for (int i = 0; i < 6; i++)
				{
					if (GetAsyncKeyState(g_WeaponList[i]))
					{
						g_LastWeapon = i;
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
#include "stdafx.h"
#include "Keyboard.h"
#include "Mouse.h"

void Keyboard::HoldKey(DWORD key)
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_KEYBOARD;
	inp.ki.wScan       = 0;
	inp.ki.time        = 0;
	inp.ki.dwExtraInfo = 0;
	inp.ki.wVk         = key;
	inp.ki.dwFlags     = 0;

	SendInput(1, &inp, sizeof(INPUT));
}

void Keyboard::ReleaseKey(DWORD key)
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_KEYBOARD;
	inp.ki.wScan       = 0;
	inp.ki.time        = 0;
	inp.ki.dwExtraInfo = 0;
	inp.ki.wVk         = key;
	inp.ki.dwFlags     = KEYEVENTF_KEYUP;

	SendInput(1, &inp, sizeof(INPUT));
}

void Keyboard::PressKey(DWORD key, DWORD holdDelayMS)
{
	if (key == 0xfe || key == 0xff) // Scroll wheel, 0xfe and 0xff are made up values
	{
		Mouse::Scroll(key == 0xff ? true : false);
	}
	else
	{
		HoldKey(key);

		if (holdDelayMS)
			Sleep(holdDelayMS);

		ReleaseKey(key);
	}
}

void Keyboard::PressKey(Bind * bind, DWORD holdDelayMS)
{
	if (bind->m_HookType == WH_MOUSE_LL)
	{
		if (bind->m_vkCode == VK_LBUTTON)
		{
			Mouse::LeftClick(holdDelayMS);
		}
		else if (bind->m_vkCode == VK_RBUTTON)
		{
			Mouse::RightClick(holdDelayMS);
		}
		else if (bind->m_vkCode == 0xfe)
		{
			Mouse::Scroll(true);
		}
		else if (bind->m_vkCode == 0xff)
		{
			Mouse::Scroll(false);
		}
	}
	else if (bind->m_HookType == WH_KEYBOARD_LL)
	{
		HoldKey(bind->m_vkCode);

		if (holdDelayMS)
			Sleep(holdDelayMS);

		ReleaseKey(bind->m_vkCode);
	}
}

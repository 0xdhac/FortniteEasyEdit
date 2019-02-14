#include "stdafx.h"
#include "Keyboard.h"

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
	HoldKey(key);

	if (holdDelayMS)
		Sleep(holdDelayMS);

	ReleaseKey(key);
}
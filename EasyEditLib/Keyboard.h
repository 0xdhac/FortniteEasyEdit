#pragma once

struct Keyboard
{
	static void HoldKey(DWORD key);
	static void ReleaseKey(DWORD key);
	static void PressKey(DWORD key, DWORD holdDelayMS);
};
#pragma once

struct DllExport Keyboard
{
	static void HoldKey(DWORD key);
	static void ReleaseKey(DWORD key);
	static void PressKey(DWORD key, DWORD holdDelayMS);
};
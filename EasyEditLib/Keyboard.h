#pragma once
#include "Binds.h"

struct Keyboard
{
	static void HoldKey(DWORD key);
	static void ReleaseKey(DWORD key);
	static void PressKey(DWORD key, DWORD holdDelayMS);
	static void PressKey(Bind* bind, DWORD holdDelayMS);
};
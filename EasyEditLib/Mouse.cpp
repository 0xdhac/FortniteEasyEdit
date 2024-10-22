#include "stdafx.h"
#include "Mouse.h"

void Mouse::LeftClickHold()
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_MOUSE;
	inp.ki.wScan       = 0;
	inp.ki.time        = 0;
	inp.ki.dwExtraInfo = 0;
	inp.mi.dwFlags     = MOUSEEVENTF_LEFTDOWN;

	SendInput(1, &inp, sizeof(INPUT));
}

void Mouse::LeftClickRelease()
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_MOUSE;
	inp.ki.wScan       = 0;
	inp.ki.time        = 0;
	inp.ki.dwExtraInfo = 0;
	inp.mi.dwFlags     = MOUSEEVENTF_LEFTUP;

	SendInput(1, &inp, sizeof(INPUT));
}

void Mouse::LeftClick(DWORD holdDelayMS)
{
	LeftClickHold();

	if (holdDelayMS)
		Sleep(holdDelayMS);

	LeftClickRelease();
}

void Mouse::RightClickHold()
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_MOUSE;
	inp.ki.wScan       = 0;
	inp.ki.time        = 0;
	inp.ki.dwExtraInfo = 0;
	inp.mi.dwFlags     = MOUSEEVENTF_RIGHTDOWN;

	SendInput(1, &inp, sizeof(INPUT));
}

void Mouse::RightClickRelease()
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_MOUSE;
	inp.ki.wScan       = 0;
	inp.ki.time        = 0;
	inp.ki.dwExtraInfo = 0;
	inp.mi.dwFlags     = MOUSEEVENTF_RIGHTUP;

	SendInput(1, &inp, sizeof(INPUT));
}

void Mouse::RightClick(DWORD holdDelayMS)
{
	RightClickHold();

	if (holdDelayMS)
		Sleep(holdDelayMS);

	RightClickRelease();
}

void Mouse::Scroll(bool up)
{
	INPUT inp;
	ZeroMemory(&inp, sizeof(inp));

	inp.type           = INPUT_MOUSE;
	inp.mi.dx          = 0;
	inp.mi.dy          = 0;
	inp.mi.dwFlags     = MOUSEEVENTF_WHEEL;
	inp.mi.time        = 0;
	inp.mi.dwExtraInfo = 0;
	inp.mi.mouseData   = up?WHEEL_DELTA:-WHEEL_DELTA;

	SendInput(1, &inp, sizeof(inp));
}

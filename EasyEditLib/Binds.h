#pragma once

#include <Windows.h>
#include <vector>
#include <string>

struct Bind
{
	Bind(std::string name, std::string displayName, int hookType, int wParam, int vkCode = 0, std::string description = "");
	std::string m_Name;
	std::string m_DisplayName;
	std::string m_Description;
	int m_HookType;
	int m_wParam;
	int m_vkCode;
	bool m_bKeyPressed; // Toggle to prevent constant input when user holds the key
};

extern std::vector<Bind*> BindList;

Bind* RegisterBind(Bind* bind);
Bind* RegisterBind(std::string name, std::string displayName, int hookType, int wParam, int vkCode = 0, std::string description = "");
unsigned int FindAndSetKeyDownOnBind(int hookType, int wParam, int vkCode = 0);
unsigned int FindAndSetKeyUpOnBind(int hookType, int wParam, int vkCode = 0);
bool UpdateBindKeyCode(std::string name, int vkCode);
Bind* FindBind(std::string name);
int FindBindKeyCode(std::string name);
bool GetBindKeyDown(Bind* bind);
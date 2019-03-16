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
	bool m_bKeyDown;
};

extern std::vector<Bind*> BindList;

void RegisterBind(Bind* bind);
unsigned int FindAndSetKeyDownOnBind(int hookType, int wParam, int vkCode = 0);
Bind* FindBind(std::string name);
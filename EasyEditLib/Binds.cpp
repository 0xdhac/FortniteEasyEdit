#include "stdafx.h"
#include "Binds.h"
#include "Config.h"

std::vector<Bind*> BindList;

Bind* RegisterBind(Bind* bind)
{
	BindList.push_back(bind);

	return bind;
}

Bind* RegisterBind(std::string name, std::string displayName, int hookType, int wParam, int vkCode, std::string description)
{
	return RegisterBind(new Bind(name, displayName, hookType, wParam, vkCode, description));
}

unsigned int FindAndSetKeyDownOnBind(int hookType, int wParam, int vkCode)
{
	unsigned int bindsSet = 0;

	for(Bind* b : BindList)
	{
		if (b->m_HookType == hookType && b->m_wParam == wParam && b->m_vkCode == vkCode)
		{
			b->m_bKeyPressed = true;
			bindsSet++;
		}
	}

	return bindsSet;
}

unsigned int FindAndSetKeyUpOnBind(int hookType, int wParam, int vkCode)
{
	unsigned int bindsSet = 0;

	for (Bind* b : BindList)
	{
		if (b->m_HookType == hookType && b->m_wParam == wParam && b->m_vkCode == vkCode)
		{
			b->m_bKeyPressed = false;
			bindsSet++;
		}
	}

	return bindsSet;
}

bool UpdateBindKeyCode(std::string name, int vkCode)
{
	for (Bind* b : BindList)
	{
		if (b->m_Name.compare(name) == 0)
		{
			b->m_vkCode = vkCode;
		}
	}

	Config::SetValue(name, vkCode);
	
	return false;
}

Bind* FindBind(std::string name)
{
	for (Bind* b : BindList)
	{
		if (b->m_Name.compare(name) == 0)
		{
			return b;
		}
	}

	return nullptr;
}

int FindBindKeyCode(std::string name)
{
	Bind* b = FindBind(name);
	if (b != nullptr)
	{
		return b->m_vkCode;
	}
	else
	{
		return 0;
	}
}

Bind::Bind(std::string name, std::string displayName, int hookType, int wParam, int vkCode, std::string description):
	m_Name(name), m_DisplayName(displayName), m_HookType(hookType), m_wParam(wParam), m_vkCode(vkCode), m_Description(description), m_bKeyPressed(false) {};

bool GetBindKeyDown(Bind* bind)
{
	if (bind->m_bKeyPressed)
	{
		if (bind->m_HookType == WH_MOUSE_LL && bind->m_wParam == WM_MOUSEWHEEL)
		{
			bind->m_bKeyPressed = false;
		}
		
		return true;
	}

	return false;
}
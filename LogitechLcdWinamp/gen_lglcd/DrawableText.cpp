#include "Stdafx.h"
#include "ScreenManager.h"

void DrawableText::SetText( wchar_t* a_Str )
{
	wcscpy_s( m_Str, MAX_PATH, a_Str );
	m_Changed = true;
}

bool DrawableText::Draw( Surface* a_Surface )
{
	if( m_Changed )
	{
		m_Changed = false;

		int text_x = m_X;
		int text_width;
		int prev_text_width = prev_len;
		int bar_x = m_X;

		Font* f = m_Font != 0 ? m_Font : a_Surface->GetFont();
		prev_len = text_width = f->MeasureWidth( m_Str );
		if( prev_text_width < 0 )
		{
			prev_text_width = text_width;
		}

		int bar_width = prev_text_width;

		// MaxWidth < 0 means right aligned, X will be the rightmost position
		if( m_MaxWidth < 0 )
		{
			if( text_width < 0 - m_MaxWidth ) 
				text_width = 0 - m_MaxWidth;
			text_x = m_X - text_width;
			bar_x = m_X - bar_width;
		}
		else
		{
			if( text_width > m_MaxWidth ) text_width = m_MaxWidth;
			if( bar_width > m_MaxWidth ) bar_width = m_MaxWidth;
		}
		a_Surface->Bar( bar_x, m_Y, bar_width - 1, 6, PIXEL_OFF );
		a_Surface->Print( m_Str, text_x, m_Y, f, PIXEL_ON, text_x + text_width );

		return true;
	}

	return false;
}
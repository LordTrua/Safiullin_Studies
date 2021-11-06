#include"framework.h"
#include <Windows.h>
#include <tchar.h>



LRESULT CALLBACK WndProc(HWND hWnd, UINT Un, WPARAM WPar, LPARAM LPar);


TCHAR WinName[] = _T("MainFrame");
int WINAPI _tWinMain(HINSTANCE This,		 // Дескриптор текущего приложения 
	HINSTANCE Prev, 	// В современных системах всегда 0 
	LPTSTR cmd, 		// Командная строка 
	int mode) 		// Режим отображения окна
{

	HBRUSH Bruh = CreateSolidBrush(RGB(65, 25, 0));
	HWND hWnd;		// Дескриптор главного окна программы 
	MSG msg; 		// Структура для хранения сообщения 
	WNDCLASS wc; 	// Класс окна
	// Определение класса окна 
	wc.hInstance = This;
	wc.lpszClassName = WinName; 				// Имя класса окна 
	wc.lpfnWndProc = WndProc; 					// Функция окна 
	wc.style = CS_HREDRAW | CS_VREDRAW; 			// Стиль окна 
	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION); 		// Стандартная иконка 
	wc.hCursor = LoadCursor(NULL, IDC_ARROW); 		// Стандартный курсор 
	wc.lpszMenuName = NULL; 					// Нет меню 
	wc.cbClsExtra = 0; 						// Нет дополнительных данных класса 
	wc.cbWndExtra = 0; 						// Нет дополнительных данных окна 
	wc.hbrBackground = Bruh; 	// Заполнение окна белым цветом 
	// Регистрация класса окна
	if (!RegisterClass(&wc)) return 0;

	
	// Создание окна 
	hWnd = CreateWindow(WinName,			// Имя класса окна 
		_T("Каркас Windows-приложения"), 		// Заголовок окна 
		WS_OVERLAPPEDWINDOW, 		// Стиль окна 
		CW_USEDEFAULT,				// x 
		CW_USEDEFAULT, 				// y	 Размеры окна 
		400, 				// width 
		300, 				// Height 
		HWND_DESKTOP, 				// Дескриптор родительского окна 
		NULL, 						// Нет меню 
		This, 						// Дескриптор приложения 
		NULL); 					// Дополнительной информации нет 

	ShowWindow(hWnd, mode); 				// Показать окно
	// Цикл обработки сообщений 

	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg); 		// Функция трансляции кодов нажатой клавиши 
		DispatchMessage(&msg); 		// Посылает сообщение функции WndProc() 
	}

	return 0;
}

// Оконная функция вызывается операционной системой
// и получает сообщения из очереди для данного приложения

LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{

	bool what;
	RECT pEllips = { 100,100,200,200 };
	RECT pEllips2 = { 150,100,250,200 };
	RECT pEllips3 = { 200,100,300,200 };
	RECT pRect = { 400,300 };
	HDC hdc;
	PAINTSTRUCT ps, ps1;
//HDC hdc;
	int x, y;
	what = false;
	int t = 0;
		switch (message)		 // Обработчик сообщений
		{
		case WM_DESTROY:
		{
			PostQuitMessage(0);
			break; 			// Завершение программы 
		}
		//case WM_CREATE:

		//break;


		/*	struct PAINTSTRUCT
	{
		HDC hdc; //Контекст устройства
		BOOL fErase; //Если TRUE — фон окна перерисовывается
		RECT rcPaint; //Недействительный прямоугольник
		BOOL fRestore; //Резерв
		BOOL fIncUpdate; //Резерв
		BYTE rgbReserved[32]; //Резерв
	};*/

		case WM_PAINT:
		{
			
			HBRUSH hBrush1,hBrush2,hBrush3,hBrush4;
			HRGN hRgnEllipse1, hRgnEllipse2, hRgnEllipse3, hRgn;
			hRgn = CreateRectRgnIndirect(&pRect);
			hBrush1 = CreateSolidBrush(RGB(255, 255, 255));
			hBrush2 = CreateSolidBrush(RGB(255, 0, 0));
			hBrush3 = CreateSolidBrush(RGB(0, 0, 0));
			hBrush4 = CreateSolidBrush(RGB(65, 25, 0));
			hRgnEllipse1 = CreateEllipticRgnIndirect(&pEllips);
			hRgnEllipse2 = CreateEllipticRgnIndirect(&pEllips2);
			hRgnEllipse3 = CreateEllipticRgnIndirect(&pEllips3);
			hdc = BeginPaint(hWnd, &ps);
			InvalidateRect(hWnd, &pEllips, false);
			//FillRgn(hdc, hRgn, hBrush[3]);
			FillRgn(hdc, hRgnEllipse1, hBrush1);
			FillRgn(hdc, hRgnEllipse2, hBrush2);
			FillRgn(hdc, hRgnEllipse3, hBrush3);
			DeleteObject(hRgnEllipse1);
			DeleteObject(hBrush1);
			DeleteObject(hRgnEllipse2);
			DeleteObject(hBrush2);
			DeleteObject(hRgnEllipse3);
			DeleteObject(hBrush3);
			DeleteObject(hdc);
			EndPaint(hWnd, &ps);
			t++;
			break;

		}


		case WM_RBUTTONUP:
		{
			x = LOWORD(lParam);
			y = HIWORD(lParam);
			SetWindowPos(hWnd, HWND_TOPMOST, x, y, 1, 1, SWP_NOSIZE);
			break;
		}

		default: 			// Обработка сообщения по умолчанию 
			return DefWindowProc(hWnd, message, wParam, lParam);
		}
		return 0;
	}
}


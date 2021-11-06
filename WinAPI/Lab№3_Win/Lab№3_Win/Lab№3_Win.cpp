// Lab№3_Win.cpp : Определяет точку входа для приложения.
//

#include "framework.h"
#include "Lab№3_Win.h"
#include <string>
#include <windows.h>
#include "mmsystem.h"
#pragma comment(lib,"Winmm.lib")
#define _UNICODE
#include <tchar.h>

std::string Stroka="                                   ";//35
#define MAX_LOADSTRING 100
// Глобальные переменные:
HINSTANCE hInst;                                // текущий экземпляр
WCHAR szTitle[MAX_LOADSTRING];                  // Текст строки заголовка
WCHAR szWindowClass[MAX_LOADSTRING];            // имя класса главного окна

// Отправить объявления функций, включенных в этот модуль кода:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: Разместите код здесь.

    // Инициализация глобальных строк
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_LAB3WIN, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Выполнить инициализацию приложения:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_LAB3WIN));

    MSG msg;

    // Цикл основного сообщения:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  ФУНКЦИЯ: MyRegisterClass()
//
//  ЦЕЛЬ: Регистрирует класс окна.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_LAB3WIN));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(CreateSolidBrush(RGB(214,237,240)));
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_LAB3WIN);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}

//
//   ФУНКЦИЯ: InitInstance(HINSTANCE, int)
//
//   ЦЕЛЬ: Сохраняет маркер экземпляра и создает главное окно
//
//   КОММЕНТАРИИ:
//
//        В этой функции маркер экземпляра сохраняется в глобальной переменной, а также
//        создается и выводится главное окно программы.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Сохранить маркер экземпляра в глобальной переменной

   HWND hWnd = CreateWindowW(szWindowClass, _T("Телефон"), WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, 230,450, nullptr, nullptr, hInstance, nullptr);


   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}

//
//  ФУНКЦИЯ: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  ЦЕЛЬ: Обрабатывает сообщения в главном окне.
//
//  WM_COMMAND  - обработать меню приложения
//  WM_PAINT    - Отрисовка главного окна
//  WM_DESTROY  - отправить сообщение о выходе и вернуться
//
//
HFONT oldFont, newFont;
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
    case WM_CREATE:
    {
        HWND button = CreateWindow(L"button", L"1", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
             10, 120, 50, 50, hWnd, (HMENU)10000, hInst, NULL);
        HWND button2 = CreateWindow(L"button", L"2", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            70, 120, 50, 50, hWnd, (HMENU)20000, hInst, NULL);
        HWND button3 = CreateWindow(L"button", L"3", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            130, 120, 50, 50, hWnd, (HMENU)30000, hInst, NULL);
        HWND button4 = CreateWindow(L"button", L"4", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            10, 180, 50, 50, hWnd, (HMENU)40000, hInst, NULL);
        HWND button5 = CreateWindow(L"button", L"5", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            70, 180, 50, 50, hWnd, (HMENU)50000, hInst, NULL);
        HWND button6 = CreateWindow(L"button", L"6", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            130, 180, 50, 50, hWnd, (HMENU)60000, hInst, NULL);
        HWND button7 = CreateWindow(L"button", L"7", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            10, 240, 50, 50, hWnd, (HMENU)7000, hInst, NULL);
        HWND button8 = CreateWindow(L"button", L"8", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            70, 240, 50, 50, hWnd, (HMENU)8000, hInst, NULL);
        HWND button9 = CreateWindow(L"button", L"9", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            130, 240, 50, 50, hWnd, (HMENU)9000, hInst, NULL);
        HWND buttonClear = CreateWindow(L"button", L"Clear", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            130, 300, 50, 50, hWnd, (HMENU)1000, hInst, NULL);
        HWND buttonCall = CreateWindow(L"button", L"Call", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            10, 300, 50, 50, hWnd, (HMENU)1100, hInst, NULL);
        HWND button0 = CreateWindow(L"button", L"0", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
            70, 300, 50, 50, hWnd, (HMENU)100, hInst, NULL);
    }break;
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
            // Разобрать выбор в меню:
            if (LOWORD(wParam)==10000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka+"1"+ "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 20000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "2" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 30000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "3" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 40000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "4" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 50000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "5" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 60000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "6" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 7000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "7" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 8000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "8" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 9000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "9" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 100)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka = Stroka + "0" + "                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 1000)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                Stroka ="                                   ";
                InvalidateRect(hWnd, NULL, TRUE);
                return 0;
            }
            if (LOWORD(wParam) == 1100)
            {
                Stroka.erase(remove_if(Stroka.begin(), Stroka.end(), isspace), Stroka.end());// Удаление пробелов
                _TCHAR* str = new TCHAR[Stroka.size() + 1];
                str[Stroka.size()] = 0;
                std::copy(Stroka.begin(), Stroka.end(), str);
                PlaySound(L"04335.wav", NULL, SND_FILENAME | SND_ASYNC | SND_LOOP);
                Sleep(10000);
                PlaySound(L"4.wav", NULL, SND_FILENAME | SND_ASYNC | SND_LOOP);
                MessageBox(NULL, str, L"Вызов!", MB_OK);
                PlaySound(NULL, NULL, SND_FILENAME);
                InvalidateRect(hWnd, NULL, TRUE);
                Stroka = Stroka+ "                                   ";
                return 0;
            }

            switch (wmId)
            {
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
        {
            PAINTSTRUCT ps;
            HDC hdc = BeginPaint(hWnd, &ps);
            newFont = CreateFont(26, 12,0, 0, 0, 0, 0, 0, DEFAULT_CHARSET, OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY,
                DEFAULT_PITCH | FF_DONTCARE, (L"Arial"));
            oldFont = (HFONT)SelectObject(hdc, newFont);
            SetBkColor(hdc, RGB(214, 237, 240));
            // TODO: Добавьте сюда любой код прорисовки, использующий HDC...
            _TCHAR* str = new TCHAR[Stroka.size() + 1];
            str[Stroka.size()] = 0;
            std::copy(Stroka.begin(), Stroka.end(), str);
           // LPCTSTR oldString = Stroka.c_str();
            TextOut(hdc, 20, 30, str, 100);
            EndPaint(hWnd, &ps);
        }
        break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Обработчик сообщений для окна "О программе".
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}


# Анализ таблиц сопряженности
## Что это такое
Анализ [таблиц сопряженности](https://ru.wikipedia.org/wiki/Таблица_сопряжённости) - метод статистического анализ зависимости между переменными. Это приложение, написанное на WinForms, реализует данный метод.
### Примеры
<img src="screenshots/1.png" width="400">
<img src="screenshots/2.png" width="400">
<img src="screenshots/3.png" width="400">

### Интересные моменты
Одним из интересных моментов реализации данного приложение является непосредственно само вычисление функций. Проблема заключается в том, что перед тем,как вычислить значение функции, следует вычислить значения ее аргументов. [Решением](https://github.com/ekostenkodev/ContingencyTableAnalysis/blob/master/ContingencyTableAnalysis/ContingencyTableAnalysis/Calculations.cs) является простой рекурсивный перебор каждого аргумента.
<img src="screenshots/4.png" width="400">

## Ссылки
Автор - ekostenkodev@gmail.com

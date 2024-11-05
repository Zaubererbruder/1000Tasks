Для того чтобы оператор foreach работал с нашим классом, в нем должен быть определен публичный метод IEnumerator GetEnumerator(). Это достаточное условие, которое я попробовал в проекте.
Для удобства есть interface IEnumerable, который как раз требует от нас реализовать этот метод.
По факту в классе AnimalCollection я использую Collection для того чтобы использовать его Enumerator. Если нас не устраивают Enumerator стандартных типов, то можем реализовать свой класс и унаследовать его от IEnumerator, где напишем свою механику обхода элементов.

https://metanit.com/sharp/tutorial/4.11.php
https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerable
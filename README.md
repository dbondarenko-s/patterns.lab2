# Структурные паттерны
Отвечают за построение удобных в поддержке иерархий классов.
1. Адаптер (Adapter)
2. Мост (Bridge)
3. Компоновщик ( Composite)
4. Декоратор (Обёртка, Decorator)
5. Фасад (Facade)
6. Flyweight (Кэш)
7. Прокси (Proxy)

Задание:
1. Используя проект первой лабораторной, добавьте новую графическую фигуру - Треугольник, не унаследованную от GraphObject (вы её получили из сторонней библиотеке).
2. Попробуйте встроить эту фигуру в вашу графическую сцену, используя адаптер.
3. Сделайте частью графической сцены композитный элемент, который может состоять из других простых или композитных графических элементов, используя компоновщик.
4. Добавьте функционал закрашивания фигуры с помощью декоратора. Разработайте фасад для работы с графической сценой и фигурами.

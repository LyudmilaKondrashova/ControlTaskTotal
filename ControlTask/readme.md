# Описание решения задачи

1. Главный метод решения задачи - **ControlTask()**.
2. Пользователю предлагается ввести длину исходного массива. При этом проверяется положительность введенного пользователем значения длины массива.
3. Если введенное пользователем значение длины массива не положительное, то на экран выводится сообщение *"Размерность массива должна быть больше нуля!"* и выполнение основного метода прекращается.
4. Иначе, создаются два массива строк:
* **array** - это исходный массив, который предлагается пользователю заполнить вручную элементами, разделяя их клавишей **Enter**. Для этого основной метод вызывает метод **FillArray(string[] arr)**, в который в качестве параметра передается массив **array**;
* **arrayResult** - массив нулевой размерности, в который в последствии будут заноситься элементы массива **array**, удовлетворяющие заданному условию.
5. Производится вывод на экран исходного массива **array**, посредством вызова метода **PrintArray(string[] arr)**, в который в качестве параметра передается массив **array**.
6. Вызывается метод **FillArrayLengthCondition(string[] arr, string[] arrResult, int lengthCond)**, заполняющий массив **arrayResult** строками массива **array**, длина которых меньше, либо равна 3. Для этого перебираются все элементы массива **array**, и при нахождении удовлетворяющего условию элемента происходит увеличение на 1 размерности массива **arrayResult** и запись найденного элемента в конец массива **arrayResult**.
 7. Параметры метода **FillArrayLengthCondition(string[] arr, string[] arrResult, int lengthCond)**:
* **string[] arr** - исходный массив строк, в котором проверяются элементы на удовлетворение заданому условию;
* **string[] arrResult** - результирующий массив строк;
* **int lengthCond** - необходимая длина элементов исходного массива.
8. Метод **FillArrayLengthCondition(string[] arr, string[] arrResult, int lengthCond)** возвращает результирующий массив строк **arrayResult**.
9. Производится вывод на экран результирующего массива **arrayResult**, посредством вызова метода **PrintArray(string[] arr)**, в который в качестве параметра передается массив **arrayResult**.
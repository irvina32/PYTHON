   
# Напишите программу, которая принимает на вход цифру,
#  обозначающую день недели, и проверяет, является ли этот день выходным.

# n = int(input("Введите число n "))

# if n < 1 or n > 7:
#     print("такого дня недели нет")
# elif n >= 1 and n <= 5:
#     print (n, "это рабочие дни")
# else:
#     print(n, "это выходной")


# Напишите программу, которая принимает на вход координаты точки (X и Y),
#  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится
#  эта точка (или на какой оси она находится).


# X = int(input("Введите число X "))
# Y = int(input("Введите число Y "))

# if X > 0 and Y > 0:
#     print('Точка находится в 1 четверти')
   
# elif X > 0 and Y < 0:
#     print('Точка находится во 4 четверти')

# elif X < 0 and Y < 0:
#     print('Точка находится в 3 четверти')

# else: 
#     print('Тoчка находится во 2 четверти')



# Напишите программу, которая по заданному номеру четверти, 
# показывает диапазон возможных координат точек в этой четверти (x и y).

# n = int(input("Введите число n "))
# X = 0
# Y = 0
# if n < 1 or n > 4:
#     print ('такой четверти нет')

# if n == 1:
#     print('X > 0: Y > 0')

# if n == 2:
#     print('X < 0: Y > 0')

# if n == 3:
#     print('X < 0: Y < 0')

# if n == 4:
#     print('X > 0: Y < 0')



# Напишите программу, которая принимает на вход координаты двух 
# точек и находит расстояние между ними в 2D пространстве.

# x1 = float(input("Введите координаты точки x1 "))
# x2 = float(input("Введите коордитаты точки x2 "))
# y1 = float(input("Введите координаты точки y1 "))
# y2 = float(input("Введите коордитаты точки y2 "))

# V = (x1 - x2)**2 + (y1 - y2)**2
# print(round(V, 2))



# Напишите программу для. проверки истинности утверждения 
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def inputNumbers(x):
    xyz = ["X", "Y", "Z"]
    a = []
    for i in range(x):
        a.append(input(f"Введите значение {xyz[i]}: "))
    return a


def checkPredicate(x):
    left = not (x[0] or x[1] or x[2])
    right = not x[0] and not x[1] and not x[2]
    result = left == right
    return result


statement = inputNumbers(3)

if checkPredicate(statement) == True:
    print(f"Утверждение истинно")
else:
    print(f"Утверждение ложно")




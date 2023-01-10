# 1.Пользователь вводит число, нужно вывести чило pi с заданной точностью(БЕЗ БИБЛИОТЕК/МОДУЛЕЙ)
# 2. Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.

# a = int(input())
# from sympy import isprime
# def dev_for_primes(a):
#     primelist = []
#     for i in range(1, a):
#         if isprime(i) and a%i == 0:
#             while a%i == 0:
#                 primelist.append(i)
#                 a //= i
#     return primelist



# 3. Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
# 4. Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100)
# многочлена и записать в файл многочлен степени k.

# *Пример:* 

# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0 

# k = int(input())
# import random
# def get_polinom(k):
#     polinom = ''
#     for i in range(k + 1):
#         if i == 0:
#             polinom += str(random.randint(1, k)) + '*x**' + str(k -i)
#         elif i == k:
#             polinom += '+' + str(random.randint(1, k))
#         else:
#             polinom += '+' + str(random.randint(1, k)) + '*x**' + str(k -i)
#     return polinom

# with open("get_polinom.txt", 'w') as f:
#     f.write(get_polinom(k))

# print(get_polinom(k))



# ДОП. Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.

import sympy

x = sympy.Symbol('x')
with open("pol1.txt", 'r') as pol1:
    a = pol1.read()
print(a)

# with open("pol2.txt", 'r') as pol2:
#     b = pol2.read()
# print(b)

# c = sympy.simplify(a+'+'+b)

# with open("pol3.txt", 'w') as f:
#     f.write(str(c))

# print(c)
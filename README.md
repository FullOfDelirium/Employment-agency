# Информационная система бюро трудоустройства
## Содержание  

[Введение](#introduction)  

[1 Описание предметной области](#domainDescription)  

[2 Сравнительный анализ](#existingSoftware)

[3 Разработка ИС](#design)    

[4 Тестирование](#testing)

[Заключение](#conclusion)  

[Список литературы](#literature)

<a name="introduction"/>

## Введение
Целью данной работы является разработка информационной системы для бюро трудоустройства. Система предназначена для поиска вакансий и работников.
<a name="domainDescription"/>

## 1 Описание предметной области
Изучаемой предметной областью является бюро по трудоустройству. Целью бюро по трудоустройству является осуществление помощи в поиске работы и рабочих. В данной предметной области участвуют два лица: работодатель и соискатель. Работодатель может создавать вакансии, просматривать резюме и заявки соискателя, а так же отвечать на них. Соискатель в свою очерень может создавать резюме, просматривать вакансии, отправлять заявки работодателю и просматривать ответы на них.

Бюро трудоустройства имеет особую актуальность. Проблематика данной предметной области заключается в том, что в наше время велик спрос на работу и квалифицированных сотрудников. В следствие чего важно, чтобы подбор необходимых "вариантов" был легким и быстрым. 
<a name="existingSoftware"/>

## 2 Сравнительный анализ существующих программных решений


<a name="design"/>

## 3 Разработка ИС
Проектирование информационной системы начинается с создания Use Case диаграммы ([Рисунок 1](#picture1)), в которой должны быть отображены действующие лица данной системы. В нашем случае это: соискатель, работодатель и модератор. 
<a name="picture1"/>
![Use Case Diagram drawio](https://user-images.githubusercontent.com/91204498/144711285-85f34aed-57e6-4a1f-a9a9-b55c88bc874b.png)

Рисунок 1 - Use Case диаграмма

Далее на основе данной Use Case диаграммы создается Data Flow диаграмма ([Рисунок 2](#picture2)). Каждый эктор помечен своим цветом: соискатель - оранжевым, модератор - розовым, а работодатель - голубым. Так же на этой диаграмме присутствуют сущности и хранилища, они помечены серо-синим.
<a name="picture2"/>
![Data Flow Diagram drawio](https://user-images.githubusercontent.com/91204498/144711322-5fb30c7a-ddc0-4bd6-995f-7b9ae7518c5c.png)

Рисунок 2 - DFD
На основе сущностей и хранилищ, изображенных на DFD, проектируется Entity Relationship диаграмма ([Рисунок 3](#picture3)). Каждая сущность содержит набор параметров с типами данных.
<a name="picture3"/>
![Entity Relationship Diagram drawio](https://user-images.githubusercontent.com/91204498/144753346-33fca7df-bf97-4034-904a-6be335beaf74.png)

Рисунок 3 - ERD

Далее на основе ERD в среде C# для каждой сущности создается класс и описывается с ее параметрами и типами данных.([Рисунок 4](#picture4))
<a name="picture4"/>

![image](https://user-images.githubusercontent.com/91204498/144712669-bb665c79-b9bc-4f20-9812-32d216d2ad57.png)

Рисунок 4 - Список классов 

Пример такого класса для сущности Соискатель(Applicant) представлен ниже:
![image](https://user-images.githubusercontent.com/91204498/144720688-d34bc5d0-7ef1-4019-b5fd-e7ce226da2ed.png)

После создания классов, для каждого из них создаются хранилища. Сначала создаем класс Stоrage, который будет содержать в себе логику работы с файлами и хранящимися объектами.

<a name="testing"/>

## 4 Тестирование

<a name="conclusion"/>

## Заключение
<a name="literature"/>

## Список литературы
2<sup>3</sup>

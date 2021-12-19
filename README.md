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
Изучаемой предметной областью является бюро по трудоустройству. Бюро по трудоустройству – посредник на рынке труда, организация, оказывающая услуги работодателям по поиску и подбору персонала и/или оказывающая услуги соискателям по поиску работы и трудоустройству. Бюро значительно упрощает поиск поиск персонала/работы, т.к. для этого нет необходимости искать/подавать объявления в газетах и расклеивать их на улице. Бюро по трудоустройству позволяет, не выходя из дома, выложить свое резюме или же вакансию на сайте. Так же есть возможность подавать заявления на вакансии прямо через сайт. 

В данной предметной области участвуют два лица: работодатель и соискатель. 

Работодатель может создавать вакансии для поиска рабочих. Так же он может просматривать резюме, которые оставили соискатели и отвечать на заявки соискателей.

В свою очередь соискатель может создавать резюме. А так же просматривать вакансии, оставленные работодателями, отправлять заявки по выбранным вакансиям работодателю и просматривать ответы на них.

Бюро трудоустройства имеет особую актуальность. Проблематика данной предметной области заключается в том, что в наше время велик спрос на работу и квалифицированных сотрудников. В следствие чего важно, чтобы подбор необходимых "вариантов" был легким и быстрым. 
<a name="existingSoftware"/>

## 2 Сравнительный анализ существующих программных решений


<a name="design"/>

## 3 Разработка ИС
Проектирование информационной системы начинается с создания Use Case диаграммы (См. Рисунок 1), в которой должны быть отображены действующие лица данной системы. В нашем случае это: соискатель, работодатель и модератор.  
  
  ![Use Case Diagram drawio](https://user-images.githubusercontent.com/91204498/144711285-85f34aed-57e6-4a1f-a9a9-b55c88bc874b.png)
<p align="center"> 
  Рисунок 1 - Use Case диаграмма
</p>
Далее на основе данной Use Case диаграммы создается Data Flow диаграмма (См. Рисунок 2). Каждый эктор помечен своим цветом: соискатель - оранжевым, модератор - розовым, а работодатель - голубым. Так же на этой диаграмме присутствуют сущности и хранилища, они помечены серо-синим.

![Data Flow Diagram drawio](https://user-images.githubusercontent.com/91204498/144711322-5fb30c7a-ddc0-4bd6-995f-7b9ae7518c5c.png)
<p align="center"> 
  Рисунок 2 - DFD
</p>
На основе сущностей и хранилищ, изображенных на DFD, проектируется Entity Relationship диаграмма (См. Рисунок 3). Каждая сущность содержит набор параметров с типами данных.

![Entity Relationship Diagram drawio](https://user-images.githubusercontent.com/91204498/144753346-33fca7df-bf97-4034-904a-6be335beaf74.png)
<p align="center"> 
  Рисунок 3 - ERD
</p>
Далее на основе ERD в среде C# для каждой сущности создается класс и описывается с ее параметрами и типами данных.(См. Рисунок 4)

![image](https://user-images.githubusercontent.com/91204498/144712669-bb665c79-b9bc-4f20-9812-32d216d2ad57.png)
<p align="center"> 
  Рисунок 4 - Список классов 
</p>
Пример такого класса для сущности Соискатель(Applicant) представлен ниже(См. Рисунок 5):

![image](https://user-images.githubusercontent.com/91204498/144720688-d34bc5d0-7ef1-4019-b5fd-e7ce226da2ed.png)
<p align="center"> 
  Рисунок 5 - Код класса для сущности Соискатель
</p>
После создания классов, для каждого из них создаются хранилища. Сначала создаем класс Stоrage, который будет содержать в себе логику работы с файлами и хранящимися объектами.(См. Рисунок 6)

![image](https://user-images.githubusercontent.com/91204498/146257777-c7b35f28-0fbd-499f-bf2d-9422d8027959.png)
<p align="center"> 
  Рисунок 6 - Код класса Storage
</p>
Так же создается клас Storages, который содержит в себе объекты, которые будут хранить объекты наших классов в процессе работы программы.(См. Рисунок 7)

![image](https://user-images.githubusercontent.com/91204498/146259711-6395cfa7-b803-4f6f-afaa-0ad2796e6c48.png)
<p align="center">
  Рисунок 7 - Код класса Storages
</p>
Далее создаются контроллеры с методами CRUD[<sup>[1]</sup>](#sourse_1) для каждой сущности. Пример кода такого контроллера для сущности резюме представлен в листинге ниже.(См. Рисунок 8)

![image](https://user-images.githubusercontent.com/91204498/146261854-924e2be0-0ff0-4fd9-917c-04afac01f27a.png)
<p align="center">
  Рисунок 8 - Код контроллера для сущности резюме
</p>
<a name="testing"/>

## 4 Тестирование

После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними.(См. Рисунок 9)

![image](https://user-images.githubusercontent.com/91204498/146639800-860b21d8-f694-4c92-901c-35cde9cde3ab.png)
<p align="center">
  Рисунок 9 - Страница Swagger UI
</p>
Проверка работы методов CRUD в сущности Resume.(См. Рисунок 10)

![Безымянный](https://user-images.githubusercontent.com/91204498/146641079-2e8b6fd9-aef2-4a76-8e32-3c3390412cde.png)
<p align="center">
  Рисунок 10 - Сущность Resume
</p>
1. Create позволяет добавлять новые записи.(См. Рисунок 11)

![Создание 1](https://user-images.githubusercontent.com/91204498/146642448-026298bd-3ad7-4de5-90fc-fa9ca8bbc9f7.png)
<p align="center">
  Рисунок 11 - Функция Create
</p>
Ввод данных о резюме осуществляется в соответсвующих полях.(См. Рисунок 12)

![Создание 2](https://user-images.githubusercontent.com/91204498/146642495-50efc7a1-f39f-4d9f-bcad-ed68cd4948a2.png)
<p align="center">
  Рисунок 12 - Ввод данных о резюме
</p>
После успешного выполнения операции сервер выводит ответ в виде:(См. Рисунок 13)

![Создание 3](https://user-images.githubusercontent.com/91204498/146642661-f7779736-1f69-4dd5-9db3-ea8107e3244b.png)
<p align="center">
  Рисунок 13 - Результат выполнения функции Create
</p>
2. Операция чтения Read позволяет извлекать определенные записи и считывать их значения.(См. Рисунок 14)

![рид 1](https://user-images.githubusercontent.com/91204498/146642899-f6f5b1ee-7add-4667-abe9-310318e465fe.png)
<p align="center">
  Рисунок 14 - Функция Read
</p>
Для считывания информации об уже созданном резюме, его ID вводится в соответствующем поле.(См. Рисунок 15)

![рид 2](https://user-images.githubusercontent.com/91204498/146643054-470db840-3c30-4483-9fa0-a9c23124c878.png)
<p align="center">
  Рисунок 15 - Считывание информации о резюме
</p>
После выполнения операции сервер выдает информацию о резюме, ID которого был введен.(См. Рисунок 16)

![рид 3](https://user-images.githubusercontent.com/91204498/146643203-a1b7fd54-dbad-4a42-945c-20621495800f.png)
<p align="center">
  Рисунок 16 - Результат выполнения функции Read
</p>                   
3. Функция Update позволяет редактировать существующие записи.(См. Рисунок 17)

![Обновление 1](https://user-images.githubusercontent.com/91204498/146643419-02c7b531-b9d5-48a8-b897-81fd58d7af4f.png)
<p align="center">
  Рисунок 17 - Функция Update
</p>                         
Для того,чтобы изменить информацию о резюме, необходимо сначала ввести его ID, после чего ввести новые данные.(См .Рисунок 18)

![Обновление 2](https://user-images.githubusercontent.com/91204498/146643661-e2b6b49e-ac29-4d27-bd5f-a401b5f6c473.png)
<p align="center">
  Рисунок 18 - Изменение информации о резюме
</p>                   
После выполнения операции сервер выводит обновленную информацию о резюме с введенным ID.(См. Рисунок 19)

![Обновление 3](https://user-images.githubusercontent.com/91204498/146643687-db271872-3a90-473e-9aef-8485fe158a41.png)
<p align="center">
  Рисунок 19 - Результат выполнения функции Update
</p>
Выполнение данной функции так же можно проверить с помощью функции Read.(См. Рисунок 20)

![Обновление 4](https://user-images.githubusercontent.com/91204498/146643722-ec324bc3-a129-493b-bdde-28792fa62c80.png)
<p align="center">
  Рисунок 20 - Результат проверки с помощью функции Read
</p>              
4. Операция Delete позволяет удалять записи. Если операция удаления прошла успешно, то ответ сервера будет "true", в противном случае "false".

Для удаления информации о резюме необходимо ввести его ID.(См. Рисунок 21)

![Удаление 1](https://user-images.githubusercontent.com/91204498/146644044-9d01978f-dac2-4a4a-925f-3af4c0b786dc.png)
<p align="center">
  Рисунок 21 - Удаление информации о резюме
</p>                
После выполнения операции сервер выводит:(См. Рисунок 22)

![Удаление 2](https://user-images.githubusercontent.com/91204498/146644137-a0f2a1f5-b38c-43fe-bab4-ed82997a2f98.png)
<p align="center">
  Рисунок 22 - Результат выполнения функции Delete
</p>              
Выполнение данной функции так же можно проверить с помощью функции Read.(См. Рисунок 23)

![Удаление проверка](https://user-images.githubusercontent.com/91204498/146644178-fff36f2e-91dc-456a-9241-05744ff83ae6.png)
<p align="center">
Рисунок 23 - Результат проверки с помощью функции Read
</p>
Функция не выводит информации о резюме с введенныйм ID, следовательно функция Delete сработала коректно
<a name="conclusion"/>

## Заключение
<a name="literature"/>
По итогам данной работы была разработана информационная система для организации работы бюро трудоустройства. Для этого были определены сущности, участвующие в данной предметной области, связи между этими сущностями, процессы обмена информацией, а также требования и задачи к системе. Полученная информационная система может выполнять функции создания, чтения, обновления и удаления записей.

Тестирование проекта дало положительный результат. Так же в дальнейшем планируется продолжить развитие данной информационной системы, добавить привязку к базе данных методы, позволяющие расширить возможности ИС.
## Список литературы
<a name="sourse_1"/>

[1. CRUD Методы](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete)

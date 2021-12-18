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

Пример такого класса для сущности Соискатель(Applicant) представлен в листинге ниже:

Листинг 1 - Код класса для сущности Соискатель

![image](https://user-images.githubusercontent.com/91204498/144720688-d34bc5d0-7ef1-4019-b5fd-e7ce226da2ed.png)

После создания классов, для каждого из них создаются хранилища. Сначала создаем класс Stоrage, который будет содержать в себе логику работы с файлами и хранящимися объектами.

Листинг 2 - Код класса Storage

![image](https://user-images.githubusercontent.com/91204498/146257777-c7b35f28-0fbd-499f-bf2d-9422d8027959.png)

Так же создается клас Storages, который содержит в себе объекты, которые будут хранить объекты наших классов в процессе работы программы.

Листинг 3 - Код класса Storages

![image](https://user-images.githubusercontent.com/91204498/146259711-6395cfa7-b803-4f6f-afaa-0ad2796e6c48.png)

Далее создаются контроллеры с методами CRUD[<sup>[1]</sup>](#sourse_1) для каждой сущности. Пример кода такого контроллера для сущности резюме представлен в листинге ниже.

Листинг 4 - Код контроллера для сущности резюме

![image](https://user-images.githubusercontent.com/91204498/146261854-924e2be0-0ff0-4fd9-917c-04afac01f27a.png)

<a name="testing"/>

## 4 Тестирование

После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними.([Рисунок 5](#picture5))
<a name="picture5"/>

![image](https://user-images.githubusercontent.com/91204498/146639800-860b21d8-f694-4c92-901c-35cde9cde3ab.png)

                                        Рисунок 5 - Страница Swagger UI

Проверка работы методов CRUD в сущности Resume.([Рисунок 6](#picture6))
<a name="picture6"/>

![Безымянный](https://user-images.githubusercontent.com/91204498/146641079-2e8b6fd9-aef2-4a76-8e32-3c3390412cde.png)

                                          Рисунок 6 - Сущность Resume

1. Create позволяет добавлять новые записи.([Рисунок 7](#picture7))
<a name="picture7"/>

![Создание 1](https://user-images.githubusercontent.com/91204498/146642448-026298bd-3ad7-4de5-90fc-fa9ca8bbc9f7.png)

                                          Рисунок 7 - Функция Create

Ввод данных о резюме осуществляется в соответсвующих полях.([Рисунок 8](#picture8))
<a name="picture8"/>

![Создание 2](https://user-images.githubusercontent.com/91204498/146642495-50efc7a1-f39f-4d9f-bcad-ed68cd4948a2.png)

                                          Рисунок 8 - Ввод данных о резюме

После успешного выполнения операции сервер выводит ответ в виде:([Рисунок 9](#picture9))
<a name="picture9"/>

![Создание 3](https://user-images.githubusercontent.com/91204498/146642661-f7779736-1f69-4dd5-9db3-ea8107e3244b.png)

                                   Рисунок 9 - Результат выполнения функции Create
         
2. Операция чтения Read позволяет извлекать определенные записи и считывать их значения.([Рисунок 10](#picture10))
<a name="picture10"/>

![рид 1](https://user-images.githubusercontent.com/91204498/146642899-f6f5b1ee-7add-4667-abe9-310318e465fe.png)

                                          Рисунок 10 - Функция Read

Для считывания информации об уже созданном резюме, его ID вводится в соответствующем поле.([Рисунок 11](#picture11))
<a name="picture11"/>

![рид 2](https://user-images.githubusercontent.com/91204498/146643054-470db840-3c30-4483-9fa0-a9c23124c878.png)

                                   Рисунок 11 - Считывание информации о резюме
                                   
После выполнения операции сервер выдает информацию о резюме, ID которого был введен.([Рисунок 12](#picture12))             <a name="picture12"/>

![рид 3](https://user-images.githubusercontent.com/91204498/146643203-a1b7fd54-dbad-4a42-945c-20621495800f.png)

                                   Рисунок 12 - Результат выполнения функции Read
                                   
3. Функция Update позволяет редактировать существующие записи.([Рисунок 13](#picture13))
<a name="picture13"/>

![Обновление 1](https://user-images.githubusercontent.com/91204498/146643419-02c7b531-b9d5-48a8-b897-81fd58d7af4f.png)

                                           Рисунок 13 - Функция Update
                                           
Для того,чтобы изменить информацию о резюме, необходимо сначала ввести его ID, после чего ввести новые данные.([Рисунок 14](#picture14))
<a name="picture14"/>

![Обновление 2](https://user-images.githubusercontent.com/91204498/146643661-e2b6b49e-ac29-4d27-bd5f-a401b5f6c473.png)

                                     Рисунок 14 - Изменение информации о резюме
                                     
После выполнения операции сервер выводит обновленную информацию о резюме с введенным ID.([Рисунок 15](#picture15))
<a name="picture15"/>

![Обновление 3](https://user-images.githubusercontent.com/91204498/146643687-db271872-3a90-473e-9aef-8485fe158a41.png)

                                   Рисунок 15 - Результат выполнения функции Update

Выполнение данной функции так же можно проверить с помощью функции Read.([Рисунок 16](#picture16))
<a name="picture16"/>

![Обновление 4](https://user-images.githubusercontent.com/91204498/146643722-ec324bc3-a129-493b-bdde-28792fa62c80.png)

                                Рисунок 16 - Результат проверки с помощью функции Read
                                
4. Операция Delete позволяет удалять записи. Если операция удаления прошла успешно, то ответ сервера будет "true", в противном случае "false".

Для удаления информации о резюме необходимо ввести его ID.([Рисунок 17](#picture17))
<a name="picture17"/>

![Удаление 1](https://user-images.githubusercontent.com/91204498/146644044-9d01978f-dac2-4a4a-925f-3af4c0b786dc.png)

                                    Рисунок 17 - Удаление информации о резюме
                                  
После выполнения операции сервер выводит:([Рисунок 18](#picture18))
<a name="picture18"/>

![Удаление 2](https://user-images.githubusercontent.com/91204498/146644137-a0f2a1f5-b38c-43fe-bab4-ed82997a2f98.png)

                                Рисунок 18 - Результат выполнения функции Delete
                                
Выполнение данной функции так же можно проверить с помощью функции Read.([Рисунок 19](#picture19))
<a name="picture19"/> 

![Удаление проверка](https://user-images.githubusercontent.com/91204498/146644178-fff36f2e-91dc-456a-9241-05744ff83ae6.png)

                                Рисунок 19 - Результат проверки с помощью функции Read

Функция не выводит информации о резюме с введенныйм ID, следовательно функция Delete сработала коректно
<a name="conclusion"/>

## Заключение
<a name="literature"/>

## Список литературы
<a name="sourse_1"/>

[1. CRUD Методы](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete)

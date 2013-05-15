/*
Navicat SQL Server Data Transfer

Source Server         : 2
Source Server Version : 90000
Source Host           : BMW\SQLEXPRESS:1433
Source Database       : Bookstore
Source Schema         : sbs

Target Server Type    : SQL Server
Target Server Version : 90000
File Encoding         : 65001

Date: 2013-05-16 00:47:44
*/

CREATE SCHEMA [sbs]
GO

-- ----------------------------
-- Table structure for [sbs].[avaliable]
-- ----------------------------
DROP TABLE [sbs].[avaliable]
GO
CREATE TABLE [sbs].[avaliable] (
[item_id] int NOT NULL ,
[warehouse_id] int NOT NULL ,
[warehouse_amount] int NOT NULL 
)


GO

-- ----------------------------
-- Records of avaliable
-- ----------------------------
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'1', N'1', N'124');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'2', N'1', N'26');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'3', N'1', N'12');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'4', N'1', N'68');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'5', N'1', N'94');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'6', N'1', N'35');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'7', N'1', N'43');
GO
INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'8', N'1', N'88');
GO

-- ----------------------------
-- Table structure for [sbs].[client_info]
-- ----------------------------
DROP TABLE [sbs].[client_info]
GO
CREATE TABLE [sbs].[client_info] (
[client_id] int NOT NULL ,
[first_name] varchar(20) NULL ,
[last_name] varchar(32) NULL 
)


GO

-- ----------------------------
-- Records of client_info
-- ----------------------------
INSERT INTO [sbs].[client_info] ([client_id], [first_name], [last_name]) VALUES (N'3', N'Василь', N'Сидоренко');
GO
INSERT INTO [sbs].[client_info] ([client_id], [first_name], [last_name]) VALUES (N'2', N'Іван', N'Іваненко');
GO
INSERT INTO [sbs].[client_info] ([client_id], [first_name], [last_name]) VALUES (N'1', N'Петро', N'Петренко');
GO

-- ----------------------------
-- Table structure for [sbs].[expeditor]
-- ----------------------------
DROP TABLE [sbs].[expeditor]
GO
CREATE TABLE [sbs].[expeditor] (
[expeditor_id] int NOT NULL ,
[first_name_exp] varchar(20) NULL ,
[last_name_exp] varchar(32) NULL ,
[shop_id] int NOT NULL ,
[transport_type] varchar(24) NULL 
)


GO

-- ----------------------------
-- Records of expeditor
-- ----------------------------
INSERT INTO [sbs].[expeditor] ([expeditor_id], [first_name_exp], [last_name_exp], [shop_id], [transport_type]) VALUES (N'1', N'Дмитро', N'Наливайко', N'1', N'Літак');
GO
INSERT INTO [sbs].[expeditor] ([expeditor_id], [first_name_exp], [last_name_exp], [shop_id], [transport_type]) VALUES (N'2', N'Петро', N'Стефанів', N'1', N'Автомобіль');
GO
INSERT INTO [sbs].[expeditor] ([expeditor_id], [first_name_exp], [last_name_exp], [shop_id], [transport_type]) VALUES (N'3', N'Василь', N'Василенко', N'1', N'Велосипед');
GO

-- ----------------------------
-- Table structure for [sbs].[goods]
-- ----------------------------
DROP TABLE [sbs].[goods]
GO
CREATE TABLE [sbs].[goods] (
[item_id] int NOT NULL ,
[book_name] varchar(100) NOT NULL ,
[price] float(53) NOT NULL ,
[authors] varchar(100) NULL ,
[about] text NULL ,
[reviev] text NULL ,
[genre] varchar(60) NULL 
)


GO

-- ----------------------------
-- Records of goods
-- ----------------------------
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'1', N'Листи в Україну', N'53', N'Юрій Андрухович', N'До книжки Юрія Андруховича (1960) — найкультовішого сучасного українського письменника-постмодерніста і Патріарха «Бу-Ба-Бу» — увійшли «канонічні» вірші з усіх його збірок, а також знаменитий цикл «Листи в Україну». Це найповніше на сьогодні вибране поета.', null, N'Поезія');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'2', N'Чотири романи', N'62', N'Валерій Шевчук', N'До нової книжки видатного сучасного українського письменника увійшли чотири широковідомі романи і повісті. Дія цих творів охоплює п’ять століть. Роман «На полі смиренному» змальовує події ХІ–ХІІ ст., «Око прірви» — події ХVI ст., «Мор» — про чуму у Львові в 20-ті роки ХVII ст., «Сповідь» — про події ХVIII ст. Позаяк у сучасній літературній практиці розмежування на романи і повісті не дуже виразне, наше видання для зручності має назву «Чотири романи».
У романі-притчі «На полі смиренному» — одному з найважливіших творів письменника — простежено епоху молодого українського християнства в його протиборстві з язичництвом на тлі болісних суперечностей між церковними догмами і реальним життям.
«Око прірви» — роман-антиутопія, що був написаний після розпаду СССР. За словами автора, «це алюзія тоталітаризму, який можна було б назвати Домом чорного світу... ним я ніби вимітав із себе сажу того чорного світу, як це буває, коли чистять димарі». Будь-яка спроба служити тим чи іншим ідеологічним системам рано чи пізно зазнає краху, адже людську природу з незмірним Божим началом неможливо втиснути в рамці створених людським розумом світоглядних схем. У романі яскраво змальовано ортодоксальну культуру середньовіччя.
Про відносність усього, крім добра і зла, дивовижно пластично, з тонкими переходами від реального до ірреального, розповідає автор у своїй наймоторошнішій і водночас найсвітлішій повісті «Мор».
Споконвічне поняття гріха і кари за нього розбудовує дискурсійний сюжет повісті «Сповідь» із наскрізним сковородинівським мотивом про істину — золотого птаха, яку треба шукати, але не ловити. Гапонівський священик і молодий писарчук дошукуються істинної суті гріха. Різновимірними були їхні переступи, та однаково суворою кара: обом довелося побувати в подобі вовкулак...', null, N'Художня література');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'3', N'Смерть малороса або ніч перед Трійцею', N'65', N'Антін Мухарський', N'Увага! Радикальна українська проза! Чорний Гумор! Читати обережно!! Можливий культорологічний шок!!!

Майже Гоголівська повість з циклу "Spirit of wild Ukraine".', null, N'Художня література ');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'4', N'Не вурдалаки', N'32', N'Світлана Талан', N'Вихованці війни, вони мали за розкіш одяг і взуття, за щастя - відвідини кінотеатру на зекономлені на їжі копійки... Вони мріяли, закохувалися, одружувалися й неділили дітей на своїх і чужих... Коли Марія та Роман побралися, вони були ще зовсім молоді, але душами вже починали сивіти: далося взнаки життя під час німецької окупації. насильство, знущання, голод, смерть проносилися перед дівчачими і хлопчачими очима - то тепер вони вурдалаки? Горору не буде, буде війна - війна за людську гідність і право на спокійну старість...', null, N'Художня література');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'5', N'Нова кухня вітамінова. Репринтне відтворення видання 1928 року. ', N'82', N'Осипа Заклинська', N'«Нова кухня вітамінова» Осипи Заклинської вперше була видана у Львові в 1928 році. 
Крім цікавих рецептів страв, яких у книзі понад тисячу, Осипа Заклинська дає дуже корисні поради й щодо ведення домашнього господарства. Незважаючи на такий поважний вік першого видання книги, ці поради не втратили своєї актуальності й сьогодні.
Це не просто книга старих рецептів та слушних порад і коментарів. Її унікальність і неповторність - у мові, якою вона написана. Читаючи її, ніби переносишся у Галичину початку XX ст., відчуваєш неповторну атмосферу старого і справжнього Львова. В книзі багато слів, які вже сьогодні не вживаються або вживаються дуже рідко. Але це лише збагачує неймовірне враження від книги, створює неповторний шарм, гарний настрій та налаштовує на домашній затишок, бо написана вона непересічною українкою, справжньою галицькою пані...', null, N'Кулінарія');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'6', N'Гра в паралельне читання.', N'34', N'Міла Іванцова', N'Роман в 2012 році посів третє місце у Всеукраїнському конкурсі "Коронація Слова"!

Жанна, героїня роману, не знала, сідаючи у вагон потягу, як недовга розлука вплине на її тривалі стосунки. Та кожного дня її тижневого відрядження традиційний любовний трикутник на відстані перетворюватиметься на складнішу фігуру. І все через синеньку флешку з оповіданнями невідомого автора, що її Жанна знайшла в купе потягу та зберегла для себе та ще декого… Тексти, знайдені на флешці, відкриватимуть очі та повертатимуть до життя привиди минулого. Чим закінчиться гра в паралельне читання з чоловіком, якого ти пустила до свого ліжка, для тебе, для нього, для інших?', null, N'Художня література');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'7', N'Несподівана вакансія', N'90', N'Джоан Ролінґ', N'У Пеґфорді на сорок п’ятому році життя раптово помирає член місцевої ради Баррі Фербразер. Ця подія шокувала містян.
У провінційному англійському затишному містечку з брукованим майданом і стародавнім монастирем, здавалося б, панує ідилія, але всередині містечка, за цим привабливим фасадом, точиться справжня війна. Заможні воюють з убогими, підлітки — з батьками, жінки — зі своїми чоловіками, вчителі — з учнями...
Несподівана вакансія у пеґфордській раді невдовзі має всі шанси спровокувати містечко на чи не найбільшу в його історії війну. Хто стане переможцем на виборах, де панують пристрасті, дворушність і несподівані викриття?
Це великий роман про маленьке містечко і перша книжка Джоан Ролінґ для дорослих. Захопливий твір, створений незрівнянним оповідачем.', null, N'Художня література');
GO
INSERT INTO [sbs].[goods] ([item_id], [book_name], [price], [authors], [about], [reviev], [genre]) VALUES (N'8', N'Час помирати', N'76', N'Кшиштоф Зануссі', N'Кшиштоф Зануссі (нар. 1939 р.) - видатний польський режисер, сценарист і письменник, лауреат Каннського кінофестивалю (1980 р.), одержав спеціальний приз МКФ у Венеції у 1982 р., а в 1984 р. - Головний приз того ж фестивалю, у 2000 р. - Гран-прі ХХІІ Московського кінофестивалю і в 2005 р. - премію ім. Параджанова "за внесок у світовий кінематограф" на Єреванському міжнародному кінофестивалі. 

«Час помирати» — це розповідь справжнього митця про його непростий шлях у мистецтві . Ця книга — черговий авторський фільм Зануссі, але зроблений за допомогою не монтажних фраз, а словесних. Життя кінематографіста в соціалістичній Польщі, спогади про фільми, про світ у форматі «схід-захід», спогади про людей, що його оточували, серед яких були Папа Іван Павло ІІ, президент Чехії Вацлав Гавел та багато інших.
Спеціально для українського видання Зануссі написав новий розділ, де розповів про своє ставлення до України, до її історії та культури.', null, N'Мемуаристика');
GO

-- ----------------------------
-- Table structure for [sbs].[orders]
-- ----------------------------
DROP TABLE [sbs].[orders]
GO
CREATE TABLE [sbs].[orders] (
[order_id] int NOT NULL ,
[item_id] int NOT NULL ,
[client_id] int NOT NULL ,
[warehouse_id] int NOT NULL ,
[amount] int NOT NULL ,
[expeditor_id] int NOT NULL ,
[order_status] varchar(22) NULL ,
[date] datetime NOT NULL 
)


GO

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'1', N'1', N'1', N'3', N'2', N'2', N'Нова', N'2013-04-28 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'1', N'2', N'1', N'1', N'1', N'2', N'Нова', N'2013-04-28 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'2', N'5', N'3', N'2', N'5', N'1', N'Відхилена', N'2013-04-28 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'3', N'5', N'3', N'1', N'2', N'1', N'Нова', N'2013-04-29 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'4', N'8', N'2', N'1', N'1', N'3', N'У виконанні', N'2013-04-30 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'5', N'3', N'1', N'4', N'1', N'2', N'Виконана', N'2013-04-30 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'6', N'4', N'1', N'1', N'2', N'1', N'Скасована', N'2013-04-30 00:00:00.000');
GO
INSERT INTO [sbs].[orders] ([order_id], [item_id], [client_id], [warehouse_id], [amount], [expeditor_id], [order_status], [date]) VALUES (N'7', N'5', N'1', N'3', N'5', N'3', N'Нова', N'2013-05-01 00:00:00.000');
GO

-- ----------------------------
-- Table structure for [sbs].[shop_assort]
-- ----------------------------
DROP TABLE [sbs].[shop_assort]
GO
CREATE TABLE [sbs].[shop_assort] (
[shop_id] int NOT NULL ,
[item_id] int NOT NULL ,
[shop_amount] int NOT NULL 
)


GO

-- ----------------------------
-- Records of shop_assort
-- ----------------------------
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'1', N'15');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'2', N'1', N'4');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'3', N'1', N'8');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'2', N'12');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'4', N'2', N'10');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'3', N'17');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'2', N'3', N'5');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'4', N'18');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'2', N'4', N'1');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'5', N'13');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'2', N'5', N'3');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'3', N'5', N'11');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'6', N'24');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'2', N'6', N'44');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'3', N'6', N'4');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'7', N'17');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'4', N'7', N'12');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'1', N'8', N'22');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'2', N'8', N'5');
GO
INSERT INTO [sbs].[shop_assort] ([shop_id], [item_id], [shop_amount]) VALUES (N'4', N'8', N'22');
GO

-- ----------------------------
-- Table structure for [sbs].[shop_warehouse]
-- ----------------------------
DROP TABLE [sbs].[shop_warehouse]
GO
CREATE TABLE [sbs].[shop_warehouse] (
[shop_id] int NOT NULL ,
[warehouse_id] int NOT NULL ,
[warehouse_type] varchar(12) NOT NULL 
)


GO

-- ----------------------------
-- Records of shop_warehouse
-- ----------------------------
INSERT INTO [sbs].[shop_warehouse] ([shop_id], [warehouse_id], [warehouse_type]) VALUES (N'1', N'1', N'shared');
GO

-- ----------------------------
-- Table structure for [sbs].[shops]
-- ----------------------------
DROP TABLE [sbs].[shops]
GO
CREATE TABLE [sbs].[shops] (
[shop_id] int NOT NULL ,
[shop_name] nvarchar(50) NOT NULL ,
[web] nvarchar(30) NULL 
)


GO

-- ----------------------------
-- Records of shops
-- ----------------------------
INSERT INTO [sbs].[shops] ([shop_id], [shop_name], [web]) VALUES (N'0', N'<All shops>', null);
GO
INSERT INTO [sbs].[shops] ([shop_id], [shop_name], [web]) VALUES (N'1', N'Amazon', N'Amazon.com');
GO
INSERT INTO [sbs].[shops] ([shop_id], [shop_name], [web]) VALUES (N'2', N'Bookstore', N'Bookstore.org');
GO
INSERT INTO [sbs].[shops] ([shop_id], [shop_name], [web]) VALUES (N'3', N'Bookzone', N'bookzone.com.ua');
GO
INSERT INTO [sbs].[shops] ([shop_id], [shop_name], [web]) VALUES (N'4', N'ebay', N'ebay.com');
GO

-- ----------------------------
-- Table structure for [sbs].[warehouse]
-- ----------------------------
DROP TABLE [sbs].[warehouse]
GO
CREATE TABLE [sbs].[warehouse] (
[warehouse_id] int NOT NULL ,
[warehouse_name] varchar(22) NOT NULL ,
[location] varchar(26) NULL 
)


GO

-- ----------------------------
-- Records of warehouse
-- ----------------------------
INSERT INTO [sbs].[warehouse] ([warehouse_id], [warehouse_name], [location]) VALUES (N'1', N'BestStorage', N'New Jersey, US');
GO
INSERT INTO [sbs].[warehouse] ([warehouse_id], [warehouse_name], [location]) VALUES (N'2', N'NovaPoshta', N'Lviv, Ukraine');
GO
INSERT INTO [sbs].[warehouse] ([warehouse_id], [warehouse_name], [location]) VALUES (N'3', N'WerehouseUS', N'Atlantic City, US');
GO
INSERT INTO [sbs].[warehouse] ([warehouse_id], [warehouse_name], [location]) VALUES (N'4', N'Storage4YOU', N'New York, US');
GO

-- ----------------------------
-- Indexes structure for table avaliable
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[avaliable]
-- ----------------------------
ALTER TABLE [sbs].[avaliable] ADD PRIMARY KEY ([item_id], [warehouse_id])
GO

-- ----------------------------
-- Indexes structure for table client_info
-- ----------------------------
CREATE INDEX [ix_name] ON [sbs].[client_info]
([first_name] ASC, [last_name] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table [sbs].[client_info]
-- ----------------------------
ALTER TABLE [sbs].[client_info] ADD PRIMARY KEY ([client_id])
GO

-- ----------------------------
-- Indexes structure for table expeditor
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[expeditor]
-- ----------------------------
ALTER TABLE [sbs].[expeditor] ADD PRIMARY KEY ([expeditor_id])
GO

-- ----------------------------
-- Indexes structure for table goods
-- ----------------------------
CREATE INDEX [ix_bookname] ON [sbs].[goods]
([book_name] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table [sbs].[goods]
-- ----------------------------
ALTER TABLE [sbs].[goods] ADD PRIMARY KEY ([item_id])
GO

-- ----------------------------
-- Indexes structure for table orders
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[orders]
-- ----------------------------
ALTER TABLE [sbs].[orders] ADD PRIMARY KEY ([order_id], [item_id], [client_id], [warehouse_id])
GO

-- ----------------------------
-- Indexes structure for table shop_assort
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[shop_assort]
-- ----------------------------
ALTER TABLE [sbs].[shop_assort] ADD PRIMARY KEY ([item_id], [shop_id])
GO

-- ----------------------------
-- Indexes structure for table shop_warehouse
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[shop_warehouse]
-- ----------------------------
ALTER TABLE [sbs].[shop_warehouse] ADD PRIMARY KEY ([shop_id], [warehouse_id])
GO

-- ----------------------------
-- Indexes structure for table shops
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[shops]
-- ----------------------------
ALTER TABLE [sbs].[shops] ADD PRIMARY KEY ([shop_id])
GO

-- ----------------------------
-- Indexes structure for table warehouse
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [sbs].[warehouse]
-- ----------------------------
ALTER TABLE [sbs].[warehouse] ADD PRIMARY KEY ([warehouse_id])
GO

-- ----------------------------
-- Foreign Key structure for table [sbs].[avaliable]
-- ----------------------------
ALTER TABLE [sbs].[avaliable] ADD FOREIGN KEY ([item_id]) REFERENCES [sbs].[goods] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [sbs].[avaliable] ADD FOREIGN KEY ([warehouse_id]) REFERENCES [sbs].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [sbs].[expeditor]
-- ----------------------------
ALTER TABLE [sbs].[expeditor] ADD FOREIGN KEY ([shop_id]) REFERENCES [sbs].[shops] ([shop_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [sbs].[orders]
-- ----------------------------
ALTER TABLE [sbs].[orders] ADD FOREIGN KEY ([client_id]) REFERENCES [sbs].[client_info] ([client_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [sbs].[orders] ADD FOREIGN KEY ([expeditor_id]) REFERENCES [sbs].[expeditor] ([expeditor_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [sbs].[orders] ADD FOREIGN KEY ([item_id]) REFERENCES [sbs].[goods] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [sbs].[orders] ADD FOREIGN KEY ([warehouse_id]) REFERENCES [sbs].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [sbs].[shop_assort]
-- ----------------------------
ALTER TABLE [sbs].[shop_assort] ADD FOREIGN KEY ([item_id]) REFERENCES [sbs].[goods] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [sbs].[shop_assort] ADD FOREIGN KEY ([shop_id]) REFERENCES [sbs].[shops] ([shop_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [sbs].[shop_warehouse]
-- ----------------------------
ALTER TABLE [sbs].[shop_warehouse] ADD FOREIGN KEY ([shop_id]) REFERENCES [sbs].[shops] ([shop_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [sbs].[shop_warehouse] ADD FOREIGN KEY ([warehouse_id]) REFERENCES [sbs].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

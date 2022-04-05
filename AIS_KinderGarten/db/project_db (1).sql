-- phpMyAdmin SQL Dump
-- version 4.4.15.7
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 22 2022 г., 23:02
-- Версия сервера: 5.5.50
-- Версия PHP: 5.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `project_db`
--

-- --------------------------------------------------------

--
-- Структура таблицы `attendance`
--

CREATE TABLE IF NOT EXISTS `attendance` (
  `id` int(11) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `three_name` varchar(255) NOT NULL,
  `reason` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `groups` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `attendance`
--

INSERT INTO `attendance` (`id`, `last_name`, `name`, `three_name`, `reason`, `date`, `groups`) VALUES
(1, 'Иванов', 'Илья', 'Александрович', 'Больничный', '2022-03-22', 'Младшая группа'),
(2, 'Дикарев', 'Роман', 'Олегович', 'Прогулял', '2022-03-22', 'Младшая группа'),
(3, 'Ковальский', 'Кирилл', 'Ренатович', 'Неизвестна', '2022-03-22', 'Старшая группа'),
(4, 'Тест', 'Тестсс', 'Поыл', 'ПАЫВп', '2022-03-21', 'Младшая группа');

-- --------------------------------------------------------

--
-- Структура таблицы `pupils`
--

CREATE TABLE IF NOT EXISTS `pupils` (
  `id` int(11) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `three_name` varchar(255) NOT NULL,
  `date_born` date NOT NULL,
  `groups` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `pupils`
--

INSERT INTO `pupils` (`id`, `last_name`, `name`, `three_name`, `date_born`, `groups`) VALUES
(0, 'Иванова', 'Анна', 'Олеговна', '2022-02-09', 'Младшая группа'),
(1, 'Иванов', 'Иван', 'Иванович', '2020-12-08', 'Младшая группа'),
(2, 'Орлов', 'Олег', 'Александрович', '2020-07-10', 'Средняя группа'),
(3, 'Смирнов', 'Александр', 'Олегович', '2014-05-20', 'Младшая группа'),
(5, 'Смирнова', 'Алена', 'Олеговна', '2020-01-20', 'Средняя группа'),
(6, 'Петров', 'Петр', 'Иванович', '2020-04-18', 'Младшая группа'),
(7, 'Шарапов', 'Василий', 'Федосеевич', '2019-12-10', 'Старшая группа'),
(8, 'Кулаков', 'Пантелей', 'Даниилович', '2019-10-10', 'Старшая группа'),
(9, 'Семёнов', 'Денис', 'Петрович', '2019-11-01', 'Старшая группа'),
(10, 'Родионов', 'Борис', 'Тимурович', '2018-11-10', 'Подготовительная группа'),
(11, 'Блинов', 'Василий', 'Георгьевич', '2019-12-12', 'Подготовительная группа'),
(12, 'Константинов', 'Лаврентий', 'Сергеевич', '2019-12-10', 'Средняя группа'),
(13, 'Герасимов', 'Олег', 'Петрович', '2007-02-20', 'Средняя группа'),
(14, 'Смирнова', 'Марина', 'Олеговна', '2024-02-20', 'Подготовительная группа'),
(15, 'Ковальский', 'Кирилл', 'Ренатович', '2003-02-25', 'Подготовительная группа'),
(16, 'Немой', 'Владимир', 'Алексеевич', '2026-03-20', 'Подготовительная группа'),
(17, 'Алексеева', 'Анастасия', 'Романовна', '2013-06-20', 'Подготовительная группа');

-- --------------------------------------------------------

--
-- Структура таблицы `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `id` int(11) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `three_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `job_title` varchar(255) NOT NULL,
  `fixed_group` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `staff`
--

INSERT INTO `staff` (`id`, `last_name`, `name`, `three_name`, `password`, `job_title`, `fixed_group`, `status`) VALUES
(1, 'Иванов', 'Иван', 'Иванович', 'admin', 'Заведующий', 'Нету', 'Администратор'),
(2, 'Иванова', 'Анна', 'Ивановна', 'user25', 'Воспитатель', 'Младшая группа', 'Пользователь'),
(3, 'Ковальский', 'Кирилл', 'Ренатович', 'kirill34', 'Директор ФСБ', 'Нету', 'Администратор'),
(4, 'Смирнова', 'Мария', 'Олеговна', 'user34', 'Воспитатель', 'Старшая группа', 'Пользователь'),
(5, 'Курьянова', 'Анастасия', 'Ивановна', 'user14', 'Воспитатель', 'Средння группа', 'Пользователь'),
(6, 'Петрова', 'Алена', 'Александровна', 'user74', 'Воспитатель', 'Подготовительная группа', 'Пользователь');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `pupils`
--
ALTER TABLE `pupils`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `attendance`
--
ALTER TABLE `attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT для таблицы `pupils`
--
ALTER TABLE `pupils`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT для таблицы `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

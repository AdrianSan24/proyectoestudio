-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-06-2018 a las 18:45:02
-- Versión del servidor: 10.1.32-MariaDB
-- Versión de PHP: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `prueba`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `atascos`
--

CREATE TABLE `atascos` (
  `Cod` int(11) NOT NULL,
  `horainicio` varchar(255) NOT NULL,
  `horafin` varchar(255) NOT NULL,
  `tiempo` varchar(255) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `CodigoMaquina` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

--
-- Volcado de datos para la tabla `atascos`
--

INSERT INTO `atascos` (`Cod`, `horainicio`, `horafin`, `tiempo`, `created_at`, `CodigoMaquina`) VALUES
(2, '17:55:20', '17:55:42', '0:00:21', '2018-06-02 17:55:57', '02033'),
(3, '19:11:16', '19:11:20', '0:00:04', '2018-06-02 19:11:23', '02033'),
(4, '16:58:31', '16:58:37', '0:00:05', '2018-06-03 16:58:41', '04025');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos`
--

CREATE TABLE `datos` (
  `horainicio` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `horafin` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `tiempoesperado` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `codigodemaquina` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `codigo` int(11) NOT NULL,
  `codigoempleado` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `Motivo` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `descripcion` text COLLATE latin1_general_ci,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `datos`
--

INSERT INTO `datos` (`horainicio`, `horafin`, `tiempoesperado`, `codigodemaquina`, `codigo`, `codigoempleado`, `Motivo`, `descripcion`, `created_at`) VALUES
('15:11:21', '15:12:27', '00:01:18', '08600', 1, 'A3C4', 'porque si', 'abdc', '2018-05-16 22:00:00'),
('18:13:06', '16:13:36', '00:00:20', '04025', 2, 'A3C4', 'Otro', 'Error ', '2018-05-20 17:28:22'),
('11:3:25', '11:3:26', '00:01', '02033', 6, 'A3C4', 'Averia Retractiladora', ' ', '2018-06-02 09:04:52'),
('11:3:25', '11:3:26', '00:01', '02033', 7, 'A3C4', 'Averia Retractiladora', ' ', '2018-06-02 09:05:06'),
('11:12:43', '11:12:44', '00:01', '02033', 8, 'A3C4', 'Averia Retractiladora', '', '2018-06-02 09:12:52'),
('13:32:37', '13:32:39', '00:01', '04025', 9, 'A3C4', 'Otro', 'hola', '2018-06-02 11:32:48'),
('17:54:49', '17:54:54', '00:04', '02033', 10, 'AD23', 'Otro', 'corte dedo', '2018-06-02 15:55:14'),
('17:55:27', '17:55:36', '00:09', '02033', 11, 'AD23', 'Falta Materia Prima', '', '2018-06-02 15:55:49'),
('18:58:15', '18:58:25', '00:09', '02033', 12, 'AD23', 'Cambio etiqueta impresora', '', '2018-06-02 16:58:55'),
('19:10:55', '19:11:4', '', '08600', 13, 'E76K', 'Averia Retractiladora', '', '2018-06-02 17:11:12');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maquina`
--

CREATE TABLE `maquina` (
  `codigo` int(11) NOT NULL,
  `codigomaquina` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `TiempoEstandar` time NOT NULL,
  `TiempodeOscilacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `maquina`
--

INSERT INTO `maquina` (`codigo`, `codigomaquina`, `TiempoEstandar`, `TiempodeOscilacion`) VALUES
(1, '02033', '00:01:30', 10),
(2, '02060', '00:10:15', 23),
(3, '02094', '00:05:20', 20),
(4, '02029', '00:11:23', 10),
(5, '04025', '00:04:00', 15),
(6, '08600', '00:02:10', 15),
(7, '04026', '00:03:00', 20),
(8, '07510', '00:03:00', 7),
(9, '08600', '00:02:05', 10),
(10, '42024', '00:02:35', 10),
(11, '42029', '00:01:30', 10),
(12, '92029', '00:01:40', 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `operarios`
--

CREATE TABLE `operarios` (
  `codigo` int(11) NOT NULL,
  `Nombre` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `Apellidos` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `Usuario` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `contrasena` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `codigoempleado` varchar(15) COLLATE latin1_general_ci NOT NULL,
  `fotoperfil` text COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `operarios`
--

INSERT INTO `operarios` (`codigo`, `Nombre`, `Apellidos`, `Usuario`, `contrasena`, `codigoempleado`, `fotoperfil`) VALUES
(1, 'Fulano', 'Mengano', 'Operario', '1234', 'A3C4', ''),
(2, 'Nombre', 'Apellido', 'Operario2', '1234', 'AD23', ''),
(3, 'Julius', 'Erving', 'Erving', '1234', 'E76K', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajomaquina`
--

CREATE TABLE `trabajomaquina` (
  `horainicio` varchar(255) NOT NULL,
  `horafinal` varchar(255) NOT NULL,
  `codigomaquina` varchar(255) NOT NULL,
  `tiempotranscurrido` varchar(255) NOT NULL,
  `Cod` int(11) NOT NULL,
  `Bandejasmalas` int(11) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `codigoempleado` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

--
-- Volcado de datos para la tabla `trabajomaquina`
--

INSERT INTO `trabajomaquina` (`horainicio`, `horafinal`, `codigomaquina`, `tiempotranscurrido`, `Cod`, `Bandejasmalas`, `created_at`, `codigoempleado`) VALUES
('17:54:7', '17:56:10', '02033', '0:02:02', 10, 0, '2018-06-02 17:56:10', 'AD23'),
('19:8:48', '19:10:43', '02033', '0:01:54', 11, 0, '2018-06-02 19:10:43', 'E76K'),
('19:10:48', '19:11:29', '08600', '0:00:39', 12, 5, '2018-06-02 19:11:29', 'E76K'),
('19:11:42', '20:14:51', '08600', '0:40:34', 13, 5, '2018-06-02 20:14:51', 'E76K'),
('11:27:9', '11:27:39', '07510', '0:00:33', 14, 0, '2018-06-03 11:27:39', 'A3C4');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios2`
--

CREATE TABLE `usuarios2` (
  `COD` int(11) NOT NULL,
  `Nombre` varchar(255) CHARACTER SET armscii8 NOT NULL,
  `Apellidos` varchar(255) CHARACTER SET armscii8 NOT NULL,
  `Usuario` varchar(255) CHARACTER SET armscii8 NOT NULL,
  `contrasena` varchar(255) CHARACTER SET armscii8 NOT NULL,
  `fotoperfil` text COLLATE latin1_general_ci NOT NULL,
  `Administrador` tinyint(1) NOT NULL,
  `codigousuario` varchar(15) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `usuarios2`
--

INSERT INTO `usuarios2` (`COD`, `Nombre`, `Apellidos`, `Usuario`, `contrasena`, `fotoperfil`, `Administrador`, `codigousuario`) VALUES
(2, 'Javier', 'Otero', 'admin', '1234', 'a', 1, 'A39B'),
(18, 'Adrian', 'Santiago', 'adrian', '1234', '', 0, 'AS21'),
(19, 'Jose', 'Perez', 'Jose', '1234', '', 0, 'JS12');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `atascos`
--
ALTER TABLE `atascos`
  ADD PRIMARY KEY (`Cod`);

--
-- Indices de la tabla `datos`
--
ALTER TABLE `datos`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `maquina`
--
ALTER TABLE `maquina`
  ADD PRIMARY KEY (`codigo`,`codigomaquina`);

--
-- Indices de la tabla `operarios`
--
ALTER TABLE `operarios`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `trabajomaquina`
--
ALTER TABLE `trabajomaquina`
  ADD PRIMARY KEY (`Cod`);

--
-- Indices de la tabla `usuarios2`
--
ALTER TABLE `usuarios2`
  ADD PRIMARY KEY (`COD`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `atascos`
--
ALTER TABLE `atascos`
  MODIFY `Cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `datos`
--
ALTER TABLE `datos`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `maquina`
--
ALTER TABLE `maquina`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `operarios`
--
ALTER TABLE `operarios`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `trabajomaquina`
--
ALTER TABLE `trabajomaquina`
  MODIFY `Cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `usuarios2`
--
ALTER TABLE `usuarios2`
  MODIFY `COD` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

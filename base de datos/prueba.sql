-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-05-2018 a las 18:06:49
-- Versión del servidor: 10.1.31-MariaDB
-- Versión de PHP: 7.2.4

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
-- Estructura de tabla para la tabla `datos`
--

CREATE TABLE `datos` (
  `Nombre` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `Apellidos` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `horainicio` time NOT NULL,
  `horafin` time NOT NULL,
  `tiempoesperado` time NOT NULL,
  `codigodemaquina` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `codigo` int(11) NOT NULL,
  `codigoempleado` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `datos`
--

INSERT INTO `datos` (`Nombre`, `Apellidos`, `horainicio`, `horafin`, `tiempoesperado`, `codigodemaquina`, `codigo`, `codigoempleado`, `created_at`) VALUES
('mengano', 'fulano', '15:11:21', '15:12:27', '00:01:18', 'A', 1, 'A3C4', '2018-05-16 22:00:00'),
('ad', 'ad', '18:13:06', '16:13:36', '00:00:20', 'B', 2, 'A3C4', '2018-05-20 17:28:22');

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
(1, 'A', '00:01:30', 10),
(2, 'B', '00:10:15', 23);

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
(1, 'operario ', 'operarioapellido', 'usuarioop', '1234', 'A3C4', ''),
(2, 'operario ', 'operarioapellido', 'usuarioop2', '1234', 'AD23', '');

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
(1, 'persona1', 'conapellidos1', 'usuario', '1234', '', 1, ''),
(2, 'ususario', 'lapolla', 'admin', '1234', '', 1, 'A39B'),
(4, 'a', 'a', 'a1', '1', '', 0, 'A23'),
(13, '', '', '', '', '', 0, ''),
(15, 'adr', 'asdd', 'as', '1234', '', 0, 'A1');

--
-- Índices para tablas volcadas
--

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
-- Indices de la tabla `usuarios2`
--
ALTER TABLE `usuarios2`
  ADD PRIMARY KEY (`COD`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `datos`
--
ALTER TABLE `datos`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `maquina`
--
ALTER TABLE `maquina`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `operarios`
--
ALTER TABLE `operarios`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios2`
--
ALTER TABLE `usuarios2`
  MODIFY `COD` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

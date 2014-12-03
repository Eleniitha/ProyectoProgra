-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-12-2014 a las 01:16:55
-- Versión del servidor: 5.6.20
-- Versión de PHP: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `tiendacsharp`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE IF NOT EXISTS `inventario` (
  `descripcion` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `nombre` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `clave` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `costo` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `total` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `codigo` varchar(15) COLLATE utf8_spanish_ci NOT NULL,
  `ubicacion` varchar(20) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`descripcion`, `nombre`, `clave`, `costo`, `total`, `codigo`, `ubicacion`) VALUES
('', '', '', '', '', '', ''),
('COMIDA', 'SOPA', '34-258-641-399-0', '$ 3.00 ', '2000 PIEZAS', '21-98-04-10-0', 'SUC'),
('COMIDA', 'ACEITE', '25-64-20-78', '$ 30.00', '5000 PIEZAS', '24-04-63-8', 'ALMA'),
('LIMPIEZA', 'FABULOSO', '8-9651-984-110', '$20.00', '6000 PIEZAS', '25-97-620-0', 'ALMA'),
('COMIDA', 'GANCITO', '98-95-60-02', '$10', '5000 PIEZAS', '28-984-6510-0', 'SUC'),
('COMIDA', 'AGUA', '47-60-840-50', '$ 7.00', '8000 PIEZAS', '77-14-56-20-9', 'SUC'),
('COMIDA', 'AGUA', '47-60-845-90', '$ 10.00', '8000 PIEZAS', '77-14-57-21-10', 'SUC'),
('COMIDA', 'GALLETAS', '12-7-60-750', '$ 15.00', '7000 PIEZAS', '47-59-620-02', 'ALMA'),
('COMIDA', 'ATUN', '65-84-7030--5', '', '', '', ''),
('LIMPIEZA', 'JABON POLVO', '587-960-280', '$ 30.00', '8200 PIEZAS', '41-02-87-05', 'ALMA'),
('LIMPIEZA', 'CLORO', '60-75-0-64-1', '$ 25.00', '7000 PIEZAS', '65-014-870-60', 'ALMA'),
('LIMPIEZA', 'PINOL', '620-78-902-50', '$ 25.00', '7200 PIEZAS', '120-320-874-02', 'ALMA'),
('COMIDA', 'ARROZ', '36-87-054', '$ 15.00', '8400 PIEZAS', '087-9504848-854', 'SUC'),
('COMIDA', 'KNORR SUIZA', '39-41-840-840', '$ 30.00', '9800 PIEZAS', '20-810-7-106851', 'SUC'),
('COMIDA', 'SPAGHETTI', '84-984-2-55-0', '$ 4.50', '5000 PIEZAS', '54-065-670-90', 'SUC'),
('LIMPIEZA', 'PASTA DENTAL', '98532-8410-010', '$ 20.00', '4500 PIEZAS', '08-90-698-05', 'SUC'),
('LIMPIEZA', 'ROLLO', '28-941-8410-81', '$ 30.00', '6000 PIEZAS', '280-820-0108-33', 'SUC'),
('COMIDA', 'CEREAL', '852-9520', '$ 50.00', '6500 PIEZAS', '05-842-98410-03', 'ALMA'),
('COMDA', 'AZUCAR', '9842-1452-95410-810', '$ 30.00', '7000 PIEZAS', '038-784-0259-01', 'ALMA'),
('limpieza', 'cloro', '1', '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ubicacion`
--

CREATE TABLE IF NOT EXISTS `ubicacion` (
  `clave_ubicacion` varchar(5) COLLATE utf8_spanish_ci NOT NULL,
  `descripcion` varchar(10) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `ubicacion`
--

INSERT INTO `ubicacion` (`clave_ubicacion`, `descripcion`) VALUES
('0', '0'),
('0', '0'),
('0', '0'),
('0', '0'),
('ALMA', 'ALMACEN'),
('SUC', 'SUCURSAL');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `nombre` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Contraseña` varchar(16) COLLATE utf8_spanish_ci NOT NULL,
  `codigo` int(20) NOT NULL,
  `ocupacion` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `telefono` varchar(15) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`nombre`, `Contraseña`, `codigo`, `ocupacion`, `telefono`) VALUES
('UrZoi', 'asdfkl', 0, 'alslfas', 'aasdas'),
('ur', 'ur', 55555, 'trabajar', '9999999'),
('asda', 'asdf', 1231, 'lol', '1231241');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE IF NOT EXISTS `venta` (
  `Folio` int(20) NOT NULL,
  `Producto` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Canprodu` int(4) NOT NULL,
  `Cantidadpagar` decimal(10,0) NOT NULL,
  `Le_atendio` varchar(50) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`Folio`, `Producto`, `Canprodu`, `Cantidadpagar`, `Le_atendio`) VALUES
(34124, 'sopa', 7, '21', 'nenis'),
(1214, 'agua', 3, '92', 'ur'),
(12312, 'agua', 3, '92', 'eee');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE IF NOT EXISTS `ventas` (
  `clave` varchar(15) COLLATE utf8_spanish_ci NOT NULL,
  `cantidad` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `nombre` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  `total` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `producto` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`clave`, `cantidad`, `nombre`, `total`, `producto`) VALUES
('1231', '1231', '123123', '12312', 13212);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta_dia`
--

CREATE TABLE IF NOT EXISTS `venta_dia` (
  `Foliod` int(20) NOT NULL,
  `Productod` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Canprodud` int(4) NOT NULL,
  `Cantidadpagard` float NOT NULL,
  `Le_Atendiod` varchar(50) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `venta_dia`
--

INSERT INTO `venta_dia` (`Foliod`, `Productod`, `Canprodud`, `Cantidadpagard`, `Le_Atendiod`) VALUES
(1214, 'agua', 3, 91.5, 'ur'),
(12312, 'agua', 3, 91.5, 'eee'),
(34124, 'sopa', 7, 21, 'nenis'),
(123123, 'tacos de labios', 21, 147, 'chepe');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `venta_dia`
--
ALTER TABLE `venta_dia`
 ADD PRIMARY KEY (`Foliod`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

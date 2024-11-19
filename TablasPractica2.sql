-- Creacion de Base de dato
CREATE DATABASE [Practica2Grupo5];


-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- Crear la tabla Listas
CREATE TABLE Listas (
    IdLista INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(150) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    IdUsuario INT NOT NULL, 
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

-- Crear la tabla Tareas
CREATE TABLE Tareas (
    IdTarea INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(150) NOT NULL,
    Descripcion NVARCHAR(255),
    Completada BIT DEFAULT 0, 
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FechaLimite DATETIME NULL,
    IdLista INT NOT NULL, 
    FOREIGN KEY (IdLista) REFERENCES Listas(IdLista)
);


-- Usuarios Ejemplos
INSERT INTO Usuarios (Nombre, Email, PasswordHash) 
VALUES ('usuario1', 'user1@example.com', 'hash123');

INSERT INTO Usuarios (Nombre, Email, PasswordHash) 
VALUES ('usuario2', 'user2@example.com', 'hash234');

INSERT INTO Usuarios (Nombre, Email, PasswordHash) 
VALUES ('usuario3', 'user3@example.com', 'hash345');


-- Listas Ejemplos
INSERT INTO Listas (Nombre, Descripcion, IdUsuario) 
VALUES ('Tareas', 'Lista de Tareas', 1);

INSERT INTO Listas (Nombre, Descripcion, IdUsuario) 
VALUES ('Compras', 'Lista de Compras', 1);

INSERT INTO Listas (Nombre, Descripcion, IdUsuario) 
VALUES ('Compromisos', 'Lista de Compromisos', 1);


-- Tareas Ejemplos
INSERT INTO Tareas (Nombre, Descripcion, IdLista) 
VALUES ('Terminar Tarea1', 'Terminar tarea para el jueves', 1);

INSERT INTO Tareas (Nombre, Descripcion, IdLista) 
VALUES ('Terminar Tarea2', 'Terminar otra tarea para el viernes', 1);

INSERT INTO Tareas (Nombre, Descripcion, IdLista) 
VALUES ('Comprar leche', 'Toca Comprar leche', 2);

INSERT INTO Tareas (Nombre, Descripcion, IdLista) 
VALUES ('Ir al Cine', 'Para ver una peli nueva', 3);
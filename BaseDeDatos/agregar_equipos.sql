-- Agrega los equipos a una base que ya tiene participantes, categorias e inscripciones.
-- Solo hace falta si la base se creó con una versión anterior de torneo_futbol5.sql.

CREATE TABLE IF NOT EXISTS equipos (
  id_equipo     INT NOT NULL AUTO_INCREMENT,
  nombre_equipo VARCHAR(50) NOT NULL,
  id_categoria  INT NOT NULL,
  id_capitan    INT NOT NULL,
  PRIMARY KEY (id_equipo),
  UNIQUE KEY uq_equipo_nombre (nombre_equipo),
  UNIQUE KEY uq_equipo_capitan (id_capitan),
  CONSTRAINT fk_equipo_categoria FOREIGN KEY (id_categoria) REFERENCES categorias (id_categoria),
  CONSTRAINT fk_equipo_capitan FOREIGN KEY (id_capitan) REFERENCES participantes (id_participante)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- NULL = el jugador todavía no tiene equipo.
-- Columna y FK van en sentencias separadas: TiDB no acepta las dos en el mismo ALTER.
ALTER TABLE inscripciones ADD COLUMN id_equipo INT NULL;

ALTER TABLE inscripciones
  ADD CONSTRAINT fk_inscripcion_equipo FOREIGN KEY (id_equipo) REFERENCES equipos (id_equipo);

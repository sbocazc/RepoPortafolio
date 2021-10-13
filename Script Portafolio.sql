CREATE TABLE area (
    id_area NUMBER(11) NOT NULL,
    nombre  NVARCHAR2(1) NOT NULL
);

ALTER TABLE area ADD CONSTRAINT area_pk PRIMARY KEY ( id_area );

CREATE TABLE rol (
ID_rol INTEGER PRIMARY KEY NOT NULL,
NOMBRE_FUNCIONARIO VARCHAR2(100) NOT NULL,
RUT_FUNCIONARIO VARCHAR2(12) NOT NULL,
ROL VARCHAR2(50) NOT NULL,
CORREO VARCHAR2(100) NOT NULL
);

ALTER TABLE rol ADD CONSTRAINT rol_pk PRIMARY KEY ( ID_rol );

CREATE TABLE contrato (
    id_contrato          NUMBER(5) NOT NULL,
    fecha_creacion       DATE NOT NULL,
    descripcion_contrato NVARCHAR2(150) NOT NULL,
    fecha_inicio         DATE NOT NULL,
    fecha_termino        DATE NOT NULL,
    empresa_id_empresa   NUMBER(5) NOT NULL
);

ALTER TABLE contrato ADD CONSTRAINT contrato_pk PRIMARY KEY ( id_contrato );

CREATE TABLE departamento (
    id_departamento     NUMBER(5) NOT NULL,
    nombre_departamento VARCHAR2(100) NOT NULL
);

ALTER TABLE departamento ADD CONSTRAINT departamento_pk PRIMARY KEY ( id_departamento );

CREATE TABLE det_empresa (
    id                 NVARCHAR2(11) NOT NULL,
    empresa_id_empresa NUMBER(5) NOT NULL,
    seccion_id_seccion NUMBER(5) NOT NULL
);

ALTER TABLE det_empresa ADD CONSTRAINT detalle_seccion_empresa_pk PRIMARY KEY ( id );

CREATE TABLE empresa (
    id_empresa       NUMBER(5) NOT NULL,
    nombre_empresa   NVARCHAR2(100) NOT NULL,
    razon_social     VARCHAR2(100 BYTE) NOT NULL,
    run_cliente      NUMBER(8) NOT NULL,
    dv_cliente       NUMBER(8) NOT NULL,
    primer_nombre    NVARCHAR2(60) NOT NULL,
    segundo_nombre   NVARCHAR2(60) NOT NULL,
    apellido_paterno NVARCHAR2(60) NOT NULL,
    apellido_materno NVARCHAR2(60) NOT NULL,
    email            NVARCHAR2(60) NOT NULL,
    numero_celular   NUMBER(10) NOT NULL
);

ALTER TABLE empresa ADD CONSTRAINT empresa_pk PRIMARY KEY ( id_empresa );

CREATE TABLE funcionario (
    id_funcionario     NUMBER(11) NOT NULL,
    nombre             NVARCHAR2(200) NOT NULL,
    email              NVARCHAR2(200) NOT NULL,
    empresa_id_empresa NUMBER(5) NOT NULL
);

ALTER TABLE funcionario ADD CONSTRAINT funcionario_pk PRIMARY KEY ( id_funcionario );

CREATE TABLE orden (
    id_orden                   NUMBER(11) NOT NULL,
    tarea                      NVARCHAR2(100) NOT NULL,
    nota                       NCLOB NOT NULL,
    estado                     NVARCHAR2(200) NOT NULL,
    funcionario_id_funcionario NUMBER(11) NOT NULL,
    area_id_area               NUMBER(11) NOT NULL
);

ALTER TABLE orden ADD CONSTRAINT orden_pk PRIMARY KEY ( id_orden );

CREATE TABLE seccion (
    id_seccion                   NUMBER(5) NOT NULL,
    nombre_seccion               NVARCHAR2(60) NOT NULL,
    departamento_id_departamento NUMBER(5) NOT NULL,
    subdepartamento_id_subdepto  NUMBER(5) NOT NULL
);

ALTER TABLE seccion ADD CONSTRAINT seccion_pk PRIMARY KEY ( id_seccion );

CREATE TABLE subdepto (
    id_subdepto  NUMBER(5) NOT NULL,
    nom_subdepto NVARCHAR2(60) NOT NULL,
    id_seccion   NUMBER(5) NOT NULL
);

ALTER TABLE subdepto ADD CONSTRAINT subdepartamento_pk PRIMARY KEY ( id_subdepto );

CREATE TABLE tar_func (
    id_tarea_funcionario       NUMBER(11) NOT NULL,
    tarea_id_tarea             NUMBER(11) NOT NULL,
    funcionario_id_funcionario NUMBER(11) NOT NULL
);

ALTER TABLE tar_func ADD CONSTRAINT tarea_funcionario_pk PRIMARY KEY ( id_tarea_funcionario );

CREATE TABLE tarea (
    id_tarea  NUMBER(11) NOT NULL,
    nombre_tarea VARCHAR(100) NOT NULL,
    descripcion_tarea VARCHAR(100),
    fecha_ini DATE NOT NULL,
    fecha_ter DATE NOT NULL,
    prioridad NVARCHAR2(200) NOT NULL,
    nombre_responsable varchar(100) not null
);

ALTER TABLE tarea ADD CONSTRAINT tarea_pk PRIMARY KEY ( id_tarea );

CREATE TABLE tarea_area (
    id_tarea_area  NUMBER(11) NOT NULL,
    area_id_area   NUMBER(11) NOT NULL,
    tarea_id_tarea NUMBER(11) NOT NULL
);

ALTER TABLE tarea_area ADD CONSTRAINT tarea_area_pk PRIMARY KEY ( id_tarea_area );

CREATE TABLE tipo_us (
    id_tipo_usuario NUMBER(5) NOT NULL,
    desc_tipo       NVARCHAR2(60) NOT NULL,
    usu_id_usuario  NUMBER(5) NOT NULL
);

CREATE UNIQUE INDEX tipo_us__idx ON
    tipo_us (
        usu_id_usuario
    ASC );

ALTER TABLE tipo_us ADD CONSTRAINT tipo_usuario_pk PRIMARY KEY ( id_tipo_usuario );

CREATE TABLE usu (
    id_usuario         NUMBER(5) NOT NULL,
    nombre_usuario     NVARCHAR2(50) NOT NULL,
    contrasena         NVARCHAR2(50) NOT NULL,
    empresa_id_empresa NUMBER(5) NOT NULL,
    tipo_usuario varchar(50) not null
);

ALTER TABLE usu ADD CONSTRAINT usuario_pk PRIMARY KEY ( id_usuario );

ALTER TABLE contrato
    ADD CONSTRAINT contrato_empresa_fk FOREIGN KEY ( empresa_id_empresa )
        REFERENCES empresa ( id_empresa );

ALTER TABLE det_empresa
    ADD CONSTRAINT det_empresa_empresa_fk FOREIGN KEY ( empresa_id_empresa )
        REFERENCES empresa ( id_empresa );

ALTER TABLE det_empresa
    ADD CONSTRAINT det_empresa_seccion_fk FOREIGN KEY ( seccion_id_seccion )
        REFERENCES seccion ( id_seccion );

ALTER TABLE funcionario
    ADD CONSTRAINT funcionario_empresa_fk FOREIGN KEY ( empresa_id_empresa )
        REFERENCES empresa ( id_empresa );

ALTER TABLE orden
    ADD CONSTRAINT orden_area_fk FOREIGN KEY ( area_id_area )
        REFERENCES area ( id_area );

ALTER TABLE orden
    ADD CONSTRAINT orden_funcionario_fk FOREIGN KEY ( funcionario_id_funcionario )
        REFERENCES funcionario ( id_funcionario );

ALTER TABLE seccion
    ADD CONSTRAINT seccion_departamento_fk FOREIGN KEY ( departamento_id_departamento )
        REFERENCES departamento ( id_departamento );

ALTER TABLE seccion
    ADD CONSTRAINT seccion_subdepartamento_fk FOREIGN KEY ( subdepartamento_id_subdepto )
        REFERENCES subdepto ( id_subdepto );

ALTER TABLE tar_func
    ADD CONSTRAINT tar_func_funcionario_fk FOREIGN KEY ( funcionario_id_funcionario )
        REFERENCES funcionario ( id_funcionario );

ALTER TABLE tar_func
    ADD CONSTRAINT tar_func_tarea_fk FOREIGN KEY ( tarea_id_tarea )
        REFERENCES tarea ( id_tarea );

ALTER TABLE tarea_area
    ADD CONSTRAINT tarea_area_area_fk FOREIGN KEY ( area_id_area )
        REFERENCES area ( id_area );

ALTER TABLE tarea_area
    ADD CONSTRAINT tarea_area_tarea_fk FOREIGN KEY ( tarea_id_tarea )
        REFERENCES tarea ( id_tarea );

ALTER TABLE tipo_us
    ADD CONSTRAINT tipo_us_usu_fk FOREIGN KEY ( usu_id_usuario )
        REFERENCES usu ( id_usuario );

ALTER TABLE usu
    ADD CONSTRAINT usu_empresa_fk FOREIGN KEY ( empresa_id_empresa )
        REFERENCES empresa ( id_empresa );
        
        
----------------------PROCEDIMIENTOS Y SECUENCIAS-------------------------------
    
CREATE SEQUENCE SEQ_USU
    INCREMENT BY 1
    START WITH 1
    MAXVALUE 99999
    NOCACHE
    NOCYCLE;
    
    
CREATE SEQUENCE SEQ_TAREA
    INCREMENT BY 1
    START WITH 1
    MAXVALUE 99999
    NOCACHE
    NOCYCLE;
    
        
CREATE SEQUENCE SEQ_EMPRESA
    INCREMENT BY 1
    START WITH 1
    MAXVALUE 99999
    NOCACHE
    NOCYCLE;
    
    CREATE SEQUENCE SEQ_ROL
    INCREMENT BY 1
    START WITH 1
    MAXVALUE 99999
    NOCACHE
    NOCYCLE;

------------------PROCEDIMIENTOS-----------------------

CREATE OR REPLACE PROCEDURE SP_AGREGAR_USU(
NOMBRE_USUARIO varchar2,
CONTRASENA integer,
TIPO_USUARIO integer)
is
begin
insert into USU values(SEQ_USU.NEXTVAL, NOMBRE_USUARIO, CONTRASENA,SEQ_EMPRESA.nextval, TIPO_USUARIO);
end;

CREATE OR REPLACE PROCEDURE SP_AGREGAR_TAREA(
PRIORIDAD varchar2,
NOMBRE_TAREA varchar2,
DESCRIPCION_TAREA varchar2,
FECHA_INI DATE,
FECHA_TER DATE,
NOMBRE_RESPONSABLE varchar2)
is
begin
insert into TAREA values(SEQ_TAREA.nextval, PRIORIDAD,NOMBRE_TAREA, DESCRIPCION_TAREA,FECHA_INI,FECHA_TER,NOMBRE_RESPONSABLE);
end;

CREATE OR REPLACE PROCEDURE SP_AGREGAR_ROL(
NOMBRE_FUNCIONARIO varchar2,
RUT_FUNCIONARIO varchar2,
ROL varchar2,
CORREO VARCHAR2)
is
begin
insert into ROL values(SEQ_ROL.nextval,NOMBRE_FUNCIONARIO,RUT_FUNCIONARIO, ROL,CORREO);
end;


CREATE OR REPLACE PROCEDURE SP_LISTAR_TAREA(tareas out SYS_REFCURSOR) 
IS BEGIN
        OPEN tareas FOR SELECT * FROM TAREA;
END;

CREATE OR REPLACE PROCEDURE SP_LISTAR_AREA(area out SYS_REFCURSOR) 
IS BEGIN
    OPEN area FOR SELECT * FROM AREA;
    
END;

CREATE OR REPLACE FUNCTION FN_LISTAR RETURN SYS_REFCURSOR IS
    L_CURSOR SYS_REFCURSOR;
BEGIN
    OPEN L_CURSOR FOR SELECT ID_AREA, NOMBRE FROM AREA;
    RETURN L_CURSOR;
END;    

select * from ROL;

INSERT INTO TIPO_US VALUES(1,'Funcionario',1); 
INSERT INTO TIPO_US VALUES(2,'Adminitrador',2); 
INSERT INTO AREA VALUES(2,'LALE'); 
INSERT INTO EMPRESA VALUES(1,'FELIPE','NINGUNA',20242066,4,'FELIPE','ANDRES','SILVA','FRAILE','FELASDISAD',12345); 
select * from tarea;
SELECT * FROM AREA;
SELECT * FROM TIPO_US;
call sp_agregar_tarea('alta','estudiar','ninguna','05/10/2021','06/10/2021','felipe');

call sp_agregar_usu('dasa','1234',6,4);
call sp_agregar_tarea('alta','estudiar','ninguna','05/10/2021','06/10/2021','felipe');
call sp_agregar_empresa('alta','estudiar','ninguna','05/10/2021','06/10/2021','felipe');
select * from usu; 
select * from empresa;


CREATE TABLE PRUEBA(
NOMBRE VARCHAR2(100) NOT NULL,
APELLIDO VARCHAR2(100) NOT NULL
);

CREATE OR REPLACE PROCEDURE SP_AGREGAR_PRUEBA(
NOMBRE varchar2,
APELLIDO varchar2)
is
begin
insert into PRUEBA values(NOMBRE,APELLIDO);
end;

INSERT INTO PRUEBA VALUES('FELIPE','Adminitrador'); 

SELECT * FROM PRUEBA;


SELECT * FROM USU WHERE NOMBRE_USUARIO = 'FELIPE' AND CONTRASENA = 1234 AND TIPO_USUARIO = 1;
SELECT * FROM USU;

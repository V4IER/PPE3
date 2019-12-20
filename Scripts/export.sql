--------------------------------------------------------
--  Fichier créé - mercredi-décembre-18-2019   
--------------------------------------------------------
DROP SEQUENCE "PPE"."SEQ_LIEU";
DROP SEQUENCE "PPE"."SEQ_TOURNEE";
DROP TABLE "PPE"."CHAUFFEUR" cascade constraints;
DROP TABLE "PPE"."COMMUNE" cascade constraints;
DROP TABLE "PPE"."CONNEXIONS" cascade constraints;
DROP TABLE "PPE"."ETAPE" cascade constraints;
DROP TABLE "PPE"."LIEU" cascade constraints;
DROP TABLE "PPE"."PERMIS" cascade constraints;
DROP TABLE "PPE"."PHOTOS" cascade constraints;
DROP TABLE "PPE"."REMORQUE" cascade constraints;
DROP TABLE "PPE"."TOURNEE" cascade constraints;
DROP TABLE "PPE"."VEHICULE" cascade constraints;
DROP VIEW "PPE"."V_TOURNEE";
--------------------------------------------------------
--  DDL for Sequence SEQ_LIEU
--------------------------------------------------------

   CREATE SEQUENCE  "PPE"."SEQ_LIEU"  MINVALUE 1457 MAXVALUE 9999 INCREMENT BY 1 START WITH 1458 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_TOURNEE
--------------------------------------------------------

   CREATE SEQUENCE  "PPE"."SEQ_TOURNEE"  MINVALUE 1164370 MAXVALUE 9999999 INCREMENT BY 1 START WITH 1164400 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table CHAUFFEUR
--------------------------------------------------------

  CREATE TABLE "PPE"."CHAUFFEUR" 
   (	"CHFID" CHAR(3 BYTE) DEFAULT NULL, 
	"CHFNOM" VARCHAR2(64 BYTE) DEFAULT NULL, 
	"CHFPRENOM" VARCHAR2(64 BYTE) DEFAULT NULL, 
	"CHFTEL" VARCHAR2(64 BYTE) DEFAULT NULL, 
	"CHFMAIL" VARCHAR2(64 BYTE) DEFAULT NULL, 
	"PERMIS" NUMBER(10,0)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table COMMUNE
--------------------------------------------------------

  CREATE TABLE "PPE"."COMMUNE" 
   (	"VILID" CHAR(32 BYTE), 
	"VILNOM" VARCHAR2(64 BYTE) DEFAULT NULL
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table CONNEXIONS
--------------------------------------------------------

  CREATE TABLE "PPE"."CONNEXIONS" 
   (	"NUMERO" NUMBER(11,0), 
	"LOGIN" VARCHAR2(64 BYTE), 
	"PASSWORD" VARCHAR2(64 BYTE), 
	"EMAIL" VARCHAR2(64 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table ETAPE
--------------------------------------------------------

  CREATE TABLE "PPE"."ETAPE" 
   (	"TRNNUM" NUMBER(11,0), 
	"ETPID" CHAR(32 BYTE), 
	"LIEUID" CHAR(32 BYTE), 
	"ETPHREMIN" DATE DEFAULT NULL, 
	"ETPHREMAX" DATE DEFAULT NULL, 
	"ETPHREDEBUT" DATE DEFAULT NULL, 
	"ETPHREFIN" DATE DEFAULT NULL, 
	"ETPNBPALLIV" NUMBER(6,0) DEFAULT NULL, 
	"ETPNBPALLIVEUR" NUMBER(6,0) DEFAULT NULL, 
	"ETPNBPALCHARG" NUMBER(6,0) DEFAULT NULL, 
	"ETPNBPALCHARGEUR" DATE DEFAULT NULL, 
	"ETPCHEQUE" NUMBER(6,0) DEFAULT NULL, 
	"ETPETATLIV" VARCHAR2(255 BYTE) DEFAULT NULL, 
	"ETPCOMMENTAIRE" VARCHAR2(255 BYTE) DEFAULT NULL, 
	"ETPVAL" VARCHAR2(255 BYTE) DEFAULT NULL, 
	"ETPKM" NUMBER(11,0) DEFAULT NULL, 
	"IDFICHIER" CHAR(3 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table LIEU
--------------------------------------------------------

  CREATE TABLE "PPE"."LIEU" 
   (	"LIEUID" CHAR(32 BYTE), 
	"VILID" CHAR(32 BYTE), 
	"LIEUNOM" VARCHAR2(255 BYTE) DEFAULT NULL, 
	"LIEUCOORDGPS" VARCHAR2(255 BYTE) DEFAULT NULL
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table PERMIS
--------------------------------------------------------

  CREATE TABLE "PPE"."PERMIS" 
   (	"IDPERMIS" NUMBER(10,0), 
	"LIBELLEPERMIS" VARCHAR2(30 BYTE), 
	"REMORQUE" NUMBER(1,0)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table PHOTOS
--------------------------------------------------------

  CREATE TABLE "PPE"."PHOTOS" 
   (	"IDFICHIER" CHAR(3 BYTE) DEFAULT NULL, 
	"TRNNUM" NUMBER(11,0), 
	"ETPID" CHAR(32 BYTE), 
	"CHEMINFICHIER" VARCHAR2(64 BYTE) DEFAULT NULL, 
	"NOMFICHIER" VARCHAR2(64 BYTE) DEFAULT NULL, 
	"DATEPHOTOS" DATE DEFAULT NULL
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table REMORQUE
--------------------------------------------------------

  CREATE TABLE "PPE"."REMORQUE" 
   (	"IDREMORQUE" NUMBER(10,0), 
	"ANNEE" VARCHAR2(4 BYTE), 
	"PTAC" NUMBER(11,0)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table TOURNEE
--------------------------------------------------------

  CREATE TABLE "PPE"."TOURNEE" 
   (	"TRNNUM" NUMBER(11,0), 
	"VEHIMMAT" CHAR(32 BYTE), 
	"CHFID" CHAR(3 BYTE), 
	"TRNCOMMENTAIRE" VARCHAR2(255 BYTE) DEFAULT NULL, 
	"TRNPECCHAUFFEUR" VARCHAR2(255 BYTE) DEFAULT NULL, 
	"TRNDTE" DATE DEFAULT NULL, 
	"REMORQUE" NUMBER(*,0)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for Table VEHICULE
--------------------------------------------------------

  CREATE TABLE "PPE"."VEHICULE" 
   (	"VEHIMMAT" CHAR(32 BYTE), 
	"VEHNOM" VARCHAR2(255 BYTE) DEFAULT NULL
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT)
  TABLESPACE "TS_APPLIMESGUEN" ;
--------------------------------------------------------
--  DDL for View V_TOURNEE
--------------------------------------------------------

  CREATE OR REPLACE FORCE VIEW "PPE"."V_TOURNEE" ("TRNNUM", "CHFPRENOM", "TRNCOMMENTAIRE", "TRNDTE", "TRNPECCHAUFFEUR", "VEHIMMAT", "ETAPE_DEPART", "ETAPE_ARRIVER") AS 
  SELECT tournee.TRNNUM,chauffeur.CHFPRENOM, TRNCOMMENTAIRE,TRNDTE,  TRNPECCHAUFFEUR,VEHIMMAT,
       (    SELECT lieu.lieunom
            from etape
            inner join lieu
            on etape.lieuid = lieu.lieuid
            where etpid = (     SELECT min(etape.ETPID)
                                from etape
                                WHERE etape.trnnum = tournee.trnnum)
            AND trnnum = tournee.trnnum) AS "ETAPE_DEPART",
            (    SELECT lieu.lieunom
            from etape
            inner join lieu
            on etape.lieuid = lieu.lieuid
            where etpid = (     SELECT max(etape.ETPID)
                                from etape
                                WHERE etape.trnnum = tournee.trnnum)
            AND trnnum = tournee.trnnum) AS "ETAPE_ARRIVER"
FROM tournee
INNER JOIN chauffeur
ON tournee.CHFID = chauffeur.CHFID
;
REM INSERTING into PPE.CHAUFFEUR
SET DEFINE OFF;
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MAT','Autret','Mathis','06.27.35.46.00','AutretMathis@mesguen.fr','1');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MQL','Quentel','Mehdi','06.31.80.60.98                  ','QuentelMehdi@mesguen.fr','1');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('NRD','Richard','Noe','06.71.18.59.80                  ','RichardNoe@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MLX','Leroux','Maxence','06.34.42.65.40                  ','LerouxMaxence@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('TFH','Floch','Thomas','06.59.59.20.13                  ','FlochThomas@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('ELN','Lebihan','Enzo','06.62.35.08.02                  ','LebihanEnzo@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('AMN','Morvan','Aaron','06.72.78.10.32                  ','MorvanAaron@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('ELE','Leborgne','Evan','06.58.28.72.17                  ','LeborgneEvan@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MPT','Prigent','Marwane','06.88.18.35.93                  ','PrigentMarwane@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('DBN','Bizien','Dorian','06.51.05.52.29                  ','BizienDorian@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('AHN','Hamon','Alexis','06.47.11.91.40                  ','HamonAlexis@mesguen.fr','3');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('TBN','Breton','Thibault','06.44.47.42.83                  ','BretonThibault@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('BAL','Abgrall','Baptiste','06.99.24.04.51                  ','AbgrallBaptiste@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('ACE','Corre','Anthony','06.84.03.04.90                  ','CorreAnthony@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('ASN','Simon','Amaury','06.46.97.80.81                  ','SimonAmaury@mesguen.fr','3');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MRD','Richard','Maelys','06.56.87.66.27                  ','RichardMaelys@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('CPT','Prigent','Chloe','06.25.16.54.72                  ','PrigentChloe@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('YTY','Tanguy','Yuna','06.80.69.11.89                  ','TanguyYuna@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('LCE','Corre','Lilou','06.26.04.98.04                  ','CorreLilou@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('PBN','Breton','Pauline','06.57.63.88.88                  ','BretonPauline@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MDL','Daniel','Maewenn','06.49.46.01.77                  ','DanielMaewenn@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('LLE','Leborgne','Lana','06.23.25.84.63                  ','LeborgneLana@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('ELS','Lucas','Elise','06.15.88.27.03                  ','LucasElise@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('GGM','Guillerm','Guillemette','06.21.64.71.35                  ','GuillermGuillemette@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MCT','Coat','Melissa','06.60.79.10.15                  ','CoatMelissa@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('NMN','Martin','Nathalie','06.45.81.97.69                  ','MartinNathalie@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('MLL','Legall','Mathilde','06.90.34.28.81                  ','LegallMathilde@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('PDN','Derrien','Pauline','06.25.30.65.32                  ','DerrienPauline@mesguen.fr','0');
Insert into PPE.CHAUFFEUR (CHFID,CHFNOM,CHFPRENOM,CHFTEL,CHFMAIL,PERMIS) values ('GNC','Nedellec','Gaetan','06.12.53.65.98                  ','NedellecGaetan@mesguen.fr','0');
REM INSERTING into PPE.COMMUNE
SET DEFINE OFF;
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29285                           ','TREFLAOUENAN                    ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29133                           ','LOCQUIREC                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29114                           ','LANNEANOU                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29023                           ','CARANTEC                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29212                           ','PLOUZANE                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29150                           ','MOELAN-SUR-MER                  ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29159                           ','PEUMERIT                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29022                           ','CAMARET-SUR-MER                 ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29107                           ','LANDUDAL                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29073                           ','GUIMAEC                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29081                           ','HUELGOAT                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29061                           ','GOUESNOU                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29163                           ','PLEYBER-CHRIST                  ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29100                           ','LANARVILY                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29271                           ','SAINT-VOUGAY                    ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29014                           ','BOTSORHEL                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29217                           ','PONT-AVEN                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29147                           ','MELLAC                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29102                           ','LANDELEAU                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29069                           ','GUILERS                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29199                           ','PLOUIGNEAU                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29162                           ','PLEYBEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29123                           ','LENNON                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29045                           ','DIRINON                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29067                           ','GUERLESQUIN                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29017                           ','BRELES                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29220                           ','PONT-L''ABBE                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29148                           ','MESPAUL                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29007                           ','BERRIEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29104                           ','LANDEVENNEC                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29296                           ','TREMEOC                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29172                           ','PLOMODIERN                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29281                           ','TOURCH                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29291                           ','TREGOUREZ                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29235                           ','LE RELECQ-KERHUON               ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29279                           ','TAULE                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29036                           ','COLLOREC                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29280                           ','TELGRUC-SUR-MER                 ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29018                           ','BRENNILIS                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29254                           ','SAINT-MARTIN-DES-CHAMPS         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29207                           ','PLOURIN-LES-MORLAIX             ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29033                           ','LE CLOITRE-PLEYBEN              ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29251                           ','SAINT-JEAN-DU-DOIGT             ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29180                           ','PLOUDIRY                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29015                           ','BOURG-BLANC                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29126                           ','LOC-BREVALAIRE                  ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29290                           ','TREGLONOU                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29124                           ','LESNEVEN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29006                           ','BENODET                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29146                           ','MELGVEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29115                           ','LANNEDERN                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29019                           ','BREST                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29111                           ','LANHOUARNEAU                    ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29001                           ','ARGOL                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29211                           ','PLOUYE                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29054                           ','LA FEUILLEE                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29169                           ','PLOGONNEC                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29130                           ','LOCMARIA-PLOUZANE               ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29030                           ','CLEDER                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29082                           ','ILE-DE-BATZ                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29052                           ','ESQUIBIEN                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29120                           ','LANVEOC                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29196                           ','PLOUGUIN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29085                           ','ILE-TUDY                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29222                           ','PORT-LAUNAY                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29208                           ','PLOURIN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29142                           ','LOTHEY                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29262                           ','SAINT-SAUVEUR                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29057                           ','LA FORET-FOUESNANT              ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29183                           ','PLOUEGAT-MOYSAN                 ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29268                           ','SAINT-THONAN                    ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29116                           ','LANNEUFFRET                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29244                           ','SAINT-DERRIEN                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29298                           ','TREOGAT                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29161                           ','PLEUVEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29004                           ','BANNALEC                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29192                           ','PLOUGOULM                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29051                           ','ERGUE-GABERIC                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29225                           ','POULDREUZIC                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29300                           ','LE TREVOUX                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29091                           ','KERLOUAN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29105                           ','LANDIVISIAU                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29165                           ','PLOBANNALEC-LESCONIL            ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29125                           ','LEUHAN                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29109                           ','LANDUNVEZ                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29182                           ','PLOUEGAT-GUERAND                ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29277                           ','SIZUN                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29228                           ','PRIMELIN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29152                           ','MOTREFF                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29186                           ','PLOUEZOC''H                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29144                           ','LA MARTYRE                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29230                           ','QUERRIEN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29011                           ','BOHARS                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29297                           ','TREMEVEN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29043                           ','DAOULAS                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29136                           ','LOCUNOLE                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29055                           ','LE FOLGOET                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29140                           ','LOPERHET                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29139                           ','LOPEREC                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29197                           ','PLOUHINEC                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29284                           ','TREFFIAGAT                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29038                           ','COMMANA                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29256                           ','SAINT-NIC                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29141                           ','LOQUEFFRET                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29070                           ','GUILER-SUR-GOYEN                ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29127                           ','LOC-EGUINER-SAINT-THEGONNEC     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29117                           ','LANNILIS                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29168                           ','PLOGOFF                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29301                           ','TREZILIDE                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29292                           ','TREGUENNEC                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29302                           ','PONT-DE-BUIS-LES-QUIMERCH       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29267                           ','SAINT-THOIS                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29003                           ','AUDIERNE                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29031                           ','CLOHARS-CARNOET                 ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29037                           ','COMBRIT                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29261                           ','SAINT-RIVOAL                    ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29103                           ','LANDERNEAU                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29086                           ','IRVILLAC                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29143                           ','MAHALON                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29097                           ','LAMPAUL-GUIMILIAU               ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29181                           ','PLOUEDERN                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29058                           ','FOUESNANT                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29238                           ','ROSCANVEL                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29026                           ','CHATEAULIN                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29020                           ','BRIEC                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29039                           ','CONCARNEAU                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29071                           ','GUILLIGOMARC''H                  ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29188                           ','PLOUGASNOU                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29240                           ','ROSNOEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29048                           ','EDERN                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29273                           ','SANTEC                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29076                           ','GUIPRONVEL                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29129                           ','LOCMARIA-BERRIEN                ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29171                           ','PLOMEUR                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29155                           ','OUESSANT                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29077                           ','GUISSENY                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29044                           ','DINEAULT                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29257                           ','SAINT-PABU                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29177                           ','PLOUARZEL                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29170                           ','PLOMELIN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29252                           ','SAINT-JEAN-TROLIMON             ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29274                           ','SCAER                           ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29137                           ','LOGONNA-DAOULAS                 ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29203                           ','PLOUNEOUR-TREZ                  ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29049                           ','ELLIANT                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29074                           ','GUIMILIAU                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29122                           ','LAZ                             ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29210                           ','PLOUVORN                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29028                           ','CLEDEN-CAP-SIZUN                ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29255                           ','SAINT-MEEN                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29098                           ','LAMPAUL-PLOUARZEL');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29029                           ','CLEDEN-POHER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29149                           ','MILIZAC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29063                           ','GOULIEN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29059                           ','GARLAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29219                           ','LE PONTHOU');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29295                           ','TREMAOUEZAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29184                           ','PLOUENAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29246                           ','SAINT-ELOY');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29013                           ','BOTMEUR');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29016                           ','BRASPARTS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29134                           ','LOCRONAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29119                           ','LANRIVOARE');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29065                           ','GOURLIZON');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29090                           ','KERLAZ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29025                           ','CAST');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29068                           ','GUICLAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29204                           ','PLOUNEVENTER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29112                           ','LANILDUT');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29173                           ','PLONEIS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29080                           ','HOPITAL-CAMFROUT');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29108                           ','LANDUDEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29293                           ','TREGUNC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29259                           ','SAINT-POL-DE-LEON');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29185                           ','PLOUESCAT');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29132                           ','LOCQUENOLE');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29113                           ','LANMEUR');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29193                           ','PLOUGOURVEST');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29094                           ','KERNOUES');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29276                           ','SIBIRIL');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29160                           ','PLABENNEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29089                           ','KERGLOFF');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29176                           ','PLONEVEZ-PORZAY');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29282                           ','TREBABU');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29075                           ','GUIPAVAS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29174                           ','PLONEOUR-LANVERN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29216                           ','PLUGUFFAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29266                           ','SAINT-THEGONNEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29278                           ','SPEZET');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29158                           ','PENMARCH');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29034                           ','LE CLOITRE-SAINT-THEGONNEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29101                           ','LANDEDA');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29239                           ','ROSCOFF');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29288                           ','TREGARANTEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29218                           ','PONT-CROIX');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29135                           ','LOCTUDY');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29167                           ','PLOGASTEL-SAINT-GERMAIN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29145                           ','CONFORT-MEILARS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29226                           ','POULLAN-SUR-MER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29128                           ','LOC-EGUINER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29245                           ','SAINT-DIVY');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29084                           ','ILE-MOLENE');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29175                           ','PLONEVEZ-DU-FAOU');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29179                           ','PLOUDANIEL');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29008                           ','BEUZEC-CAP-SIZUN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29250                           ','SAINT-HERNIN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29229                           ','QUEMENEVEN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29042                           ','CROZON');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29079                           ','HENVIC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29265                           ','SAINTE-SEVE');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29040                           ','LE CONQUET');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29275                           ','SCRIGNAC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29249                           ','SAINT-GOAZEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29151                           ','MORLAIX');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29263                           ','SAINT-SEGAL');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29209                           ','PLOUVIEN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29106                           ','LANDREVARZEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29195                           ','PLOUGUERNEAU');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29221                           ','PORSPODER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29289                           ','TREGARVAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29041                           ','CORAY');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29110                           ','LANGOLEN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29010                           ','BODILIS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29060                           ','GOUESNACH');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29202                           ','PLOUNEOUR-MENEZ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29236                           ','RIEC-SUR-BELON');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29187                           ','PLOUGAR');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29189                           ','PLOUGASTEL-DAOULAS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29035                           ','COAT-MEAL');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29213                           ','PLOUZEVEDE');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29248                           ','SAINT-FREGANT');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29153                           ','NEVEZ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29224                           ','POULDERGAT');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29299                           ','TREOUERGAT');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29005                           ','BAYE');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29024                           ','CARHAIX-PLOUGUER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29260                           ','SAINT-RENAN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29047                           ','LE DRENNEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29099                           ','LAMPAUL-PLOUDALMEZEAU');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29093                           ','KERNILIS');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29046                           ','DOUARNENEZ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29056                           ','LA FOREST-LANDERNEAU');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29286                           ','TREFLEVENEZ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29205                           ','PLOUNEVEZEL');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29012                           ','BOLAZEC');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29241                           ','ROSPORDEN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29198                           ','PLOUIDER');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29190                           ','PLOUGONVELIN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29002                           ','ARZANO');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29227                           ','POULLAOUEN');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29095                           ','KERSAINT-PLABENNEC              ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29066                           ','GUENGAT                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29215                           ','PLOZEVET                        ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29243                           ','SAINT-COULITZ                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29087                           ','LE JUCH                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29201                           ','PLOUMOGUER                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29191                           ','PLOUGONVEN                      ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29078                           ','HANVEC                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29053                           ','LE FAOU                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29021                           ','BRIGNOGAN-PLAGE                 ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29270                           ','SAINT-URBAIN                    ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29083                           ','ILE-DE-SEIN                     ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29166                           ','PLOEVEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29214                           ','PLOVAN                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29264                           ','SAINT-SERVAIS                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29247                           ','SAINT-EVARZEC                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29032                           ','CLOHARS-FOUESNANT               ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29294                           ','LE TREHOU                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29233                           ','QUIMPERLE                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29287                           ','TREFLEZ                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29234                           ','REDENE                          ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29027                           ','CHATEAUNEUF-DU-FAOU             ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29156                           ','PENCRAN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29072                           ','GUILVINEC                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29178                           ','PLOUDALMEZEAU                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29272                           ','SAINT-YVI                       ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29237                           ','LA ROCHE-MAURICE                ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29062                           ','GOUEZEC                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29064                           ','GOULVEN                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29232                           ','QUIMPER                         ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29269                           ','SAINT-THURIEN                   ');
Insert into PPE.COMMUNE (VILID,VILNOM) values ('29131                           ','LOCMELAR                        ');
REM INSERTING into PPE.CONNEXIONS
SET DEFINE OFF;
Insert into PPE.CONNEXIONS (NUMERO,LOGIN,PASSWORD,EMAIL) values ('47','MQL','b9d4390f67bd5410f884344b31d0446b','QuentelMehdi@mesguen.fr');
Insert into PPE.CONNEXIONS (NUMERO,LOGIN,PASSWORD,EMAIL) values ('46','MAT','e2404621b1ad01f647c5b220f932bde7','AutretMathis@mesguen.fr');
REM INSERTING into PPE.ETAPE
SET DEFINE OFF;
Insert into PPE.ETAPE (TRNNUM,ETPID,LIEUID,ETPHREMIN,ETPHREMAX,ETPHREDEBUT,ETPHREFIN,ETPNBPALLIV,ETPNBPALLIVEUR,ETPNBPALCHARG,ETPNBPALCHARGEUR,ETPCHEQUE,ETPETATLIV,ETPCOMMENTAIRE,ETPVAL,ETPKM,IDFICHIER) values ('1164399','1                               ','1427                            ',to_date('29/11/19','DD/MM/RR'),to_date('29/11/19','DD/MM/RR'),null,null,null,null,null,null,null,null,'RAS',null,null,null);
Insert into PPE.ETAPE (TRNNUM,ETPID,LIEUID,ETPHREMIN,ETPHREMAX,ETPHREDEBUT,ETPHREFIN,ETPNBPALLIV,ETPNBPALLIVEUR,ETPNBPALCHARG,ETPNBPALCHARGEUR,ETPCHEQUE,ETPETATLIV,ETPCOMMENTAIRE,ETPVAL,ETPKM,IDFICHIER) values ('1164399','2                               ','1438                            ',to_date('29/11/19','DD/MM/RR'),to_date('29/11/19','DD/MM/RR'),null,null,null,null,null,null,null,null,'Cargaison détruite',null,null,null);
REM INSERTING into PPE.LIEU
SET DEFINE OFF;
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1427                            ','29001                           ','Auchan ARGOL',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1428                            ','29002                           ','Monoprix ARZANO',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1429                            ','29003                           ','Auchan AUDIERNE',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1430                            ','29004                           ','Super U BANNALEC',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1431                            ','29005                           ','Proxi BAYE',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1432                            ','29006                           ','Biocoop BENODET',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1433                            ','29007                           ','Casino BERRIEN',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1434                            ','29008                           ','Super U BEUZEC-CAP-SIZUN',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1435                            ','29010                           ','Proxi BODILIS',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1436                            ','29011                           ','Monoprix BOHARS',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1437                            ','29012                           ','Leclerc BOLAZEC',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1438                            ','29013                           ','Franprix BOTMEUR',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1439                            ','29014                           ','Auchan BOTSORHEL',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1440                            ','29015                           ','Auchan BOURG-BLANC',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1441                            ','29016                           ','Carrefour BRASPARTS',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1442                            ','29017                           ','Auchan BRELES',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1443                            ','29018                           ','Casino BRENNILIS',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1444                            ','29019                           ','Franprix BREST',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1445                            ','29020                           ','Carrefour BRIEC',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1446                            ','29021                           ','Carrefour Market BRIGNOGAN-PLAGE',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1447                            ','29022                           ','Carrefour CAMARET-SUR-MER',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1448                            ','29023                           ','Casino CARANTEC',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1449                            ','29024                           ','Super U CARHAIX-PLOUGUER',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1450                            ','29025                           ','Franprix CAST',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1451                            ','29026                           ','Carrefour Market CHATEAULIN',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1452                            ','29027                           ','Super U CHATEAUNEUF-DU-FAOU',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1453                            ','29028                           ','Franprix  CLEDEN-CAP-SIZUN',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1454                            ','29029                           ','Proxi CLEDEN-POHER',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1455                            ','29030                           ','Franprix CLEDER',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1456                            ','29031                           ','Intermarche CLOHARS-CARNOET',null);
Insert into PPE.LIEU (LIEUID,VILID,LIEUNOM,LIEUCOORDGPS) values ('1457                            ','29134                           ','LECLERC LOCRONAN',null);
REM INSERTING into PPE.PERMIS
SET DEFINE OFF;
Insert into PPE.PERMIS (IDPERMIS,LIBELLEPERMIS,REMORQUE) values ('0','C1','0');
Insert into PPE.PERMIS (IDPERMIS,LIBELLEPERMIS,REMORQUE) values ('1','C1E','1');
Insert into PPE.PERMIS (IDPERMIS,LIBELLEPERMIS,REMORQUE) values ('2','C','0');
Insert into PPE.PERMIS (IDPERMIS,LIBELLEPERMIS,REMORQUE) values ('3','CE','1');
REM INSERTING into PPE.PHOTOS
SET DEFINE OFF;
Insert into PPE.PHOTOS (IDFICHIER,TRNNUM,ETPID,CHEMINFICHIER,NOMFICHIER,DATEPHOTOS) values ('1  ','1164399','1                               ','C:\Users\18egardent\','pomme.png',to_date('29/11/19','DD/MM/RR'));
Insert into PPE.PHOTOS (IDFICHIER,TRNNUM,ETPID,CHEMINFICHIER,NOMFICHIER,DATEPHOTOS) values ('3  ','1164399','2                               ','\\bts-ad2\RESSOURCE_PEDAGOGIQUE\SIO2\PPE\','MesguenCasse.png',to_date('29/11/19','DD/MM/RR'));
REM INSERTING into PPE.REMORQUE
SET DEFINE OFF;
Insert into PPE.REMORQUE (IDREMORQUE,ANNEE,PTAC) values ('1130','2013','875');
Insert into PPE.REMORQUE (IDREMORQUE,ANNEE,PTAC) values ('1131','2018','1380');
Insert into PPE.REMORQUE (IDREMORQUE,ANNEE,PTAC) values ('1132','2016','900');
REM INSERTING into PPE.TOURNEE
SET DEFINE OFF;
Insert into PPE.TOURNEE (TRNNUM,VEHIMMAT,CHFID,TRNCOMMENTAIRE,TRNPECCHAUFFEUR,TRNDTE,REMORQUE) values ('1164399','BD-802-HE                       ','ELS','Corre sur BD-802-HE',null,to_date('29/11/19','DD/MM/RR'),null);
REM INSERTING into PPE.VEHICULE
SET DEFINE OFF;
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('BD-802-HE                       ','MERCEDES');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('ER-862-IQ                       ','SCANIA');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('FJ-553-HU                       ','VOLVO');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('HO-766-TL                       ','SCANIA');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('IP-540-OX                       ','MAN');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('IZ-221-YP                       ','SCANIA');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('JZ-782-IL                       ','MAN');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('LE-383-TY                       ','MAN');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('OP-958-OM                       ','SCANIA');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('PJ-818-MU                       ','SCANIA');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('PW-231-BN                       ','VOLVO');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('RW-979-GC                       ','MERCEDES');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('RY-709-GU                       ','VOLVO');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('TB-301-PJ                       ','MAN');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('TO-971-YB                       ','VOLVO');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('TT-815-QS                       ','MAN');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('VL-924-XU                       ','MERCEDES');
Insert into PPE.VEHICULE (VEHIMMAT,VEHNOM) values ('XG-597-CO                       ','VOLVO');
--------------------------------------------------------
--  DDL for Trigger TRG_CHAUFFEUR_INIT
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PPE"."TRG_CHAUFFEUR_INIT" 
BEFORE INSERT OR UPDATE ON CHAUFFEUR
FOR EACH ROW
BEGIN
  :NEW.CHFID := CHFID_FONCTION(:NEW.CHFNOM, :NEW.CHFPRENOM);
  :NEW.CHFNOM := SansAccent(:NEW.CHFNOM);
  :NEW.CHFPRENOM := SansAccent(:NEW.CHFPRENOM);
  :NEW.CHFMAIL := CHFMAIL_FONCTION(:new.chfnom, :new.chfprenom);
END;
/
ALTER TRIGGER "PPE"."TRG_CHAUFFEUR_INIT" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENT_LIEU
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PPE"."TRG_INCREMENT_LIEU" 
BEFORE INSERT ON LIEU 
FOR EACH ROW
BEGIN
  SELECT SEQ_LIEU.NEXTVAL INTO :NEW.LIEUID FROM DUAL;
  DBMS_OUTPUT.PUT_LINE('Auto-incrément effectué');
END;

/
ALTER TRIGGER "PPE"."TRG_INCREMENT_LIEU" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_INCREMENT_TOURNEE
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PPE"."TRG_INCREMENT_TOURNEE" 
BEFORE INSERT ON TOURNEE 
FOR EACH ROW
BEGIN
  SELECT SEQ_TOURNEE.NEXTVAL INTO :NEW.TRNNUM FROM DUAL;
  DBMS_OUTPUT.PUT_LINE('Auto-incrément effectué');
END;

/
ALTER TRIGGER "PPE"."TRG_INCREMENT_TOURNEE" ENABLE;
--------------------------------------------------------
--  Constraints for Table VEHICULE
--------------------------------------------------------

  ALTER TABLE "PPE"."VEHICULE" MODIFY ("VEHIMMAT" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CONNEXIONS
--------------------------------------------------------

  ALTER TABLE "PPE"."CONNEXIONS" MODIFY ("NUMERO" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."CONNEXIONS" MODIFY ("LOGIN" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."CONNEXIONS" MODIFY ("PASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."CONNEXIONS" MODIFY ("EMAIL" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table LIEU
--------------------------------------------------------

  ALTER TABLE "PPE"."LIEU" MODIFY ("LIEUID" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."LIEU" MODIFY ("VILID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table REMORQUE
--------------------------------------------------------

  ALTER TABLE "PPE"."REMORQUE" MODIFY ("IDREMORQUE" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."REMORQUE" MODIFY ("ANNEE" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."REMORQUE" MODIFY ("PTAC" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PERMIS
--------------------------------------------------------

  ALTER TABLE "PPE"."PERMIS" MODIFY ("IDPERMIS" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."PERMIS" MODIFY ("LIBELLEPERMIS" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."PERMIS" MODIFY ("REMORQUE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CHAUFFEUR
--------------------------------------------------------

  ALTER TABLE "PPE"."CHAUFFEUR" MODIFY ("CHFID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table COMMUNE
--------------------------------------------------------

  ALTER TABLE "PPE"."COMMUNE" MODIFY ("VILID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table TOURNEE
--------------------------------------------------------

  ALTER TABLE "PPE"."TOURNEE" MODIFY ("TRNNUM" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."TOURNEE" MODIFY ("VEHIMMAT" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."TOURNEE" MODIFY ("CHFID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ETAPE
--------------------------------------------------------

  ALTER TABLE "PPE"."ETAPE" MODIFY ("TRNNUM" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."ETAPE" MODIFY ("ETPID" NOT NULL ENABLE);
 
  ALTER TABLE "PPE"."ETAPE" MODIFY ("LIEUID" NOT NULL ENABLE);

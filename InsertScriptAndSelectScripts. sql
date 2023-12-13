INSERT INTO "Professions" ("Id","Name") values(1,'Калибровщик')
INSERT INTO "Professions" ("Id","Name") values(2,'Уборщик')
INSERT INTO "Professions" ("Id","Name") values(3,'Директор')
INSERT INTO "Professions" ("Id","Name") values(4,'Разноробочий')

INSERT INTO "Operations" ("Id","Name") values(1,'Сработка')
INSERT INTO "Operations" ("Id","Name") values(2,'Производство')
INSERT INTO "Operations" ("Id","Name") values(3,'Рефакторинг')

INSERT INTO "Tarifs" ("Id","CountPerHour","StandartId") values(1,200,1)
INSERT INTO "Tarifs" ("Id","CountPerHour","StandartId") values(2,300,2)
INSERT INTO "Tarifs" ("Id","CountPerHour","StandartId") values(3,334,4)
INSERT INTO "Tarifs" ("Id","CountPerHour","StandartId") values(4,305,3)

INSERT INTO "Details" ("Id","Name","TypeDetail","Measurement","Price") values(0,'Коленвал ВАЗ',1,'КГ',1500);
INSERT INTO "Details" ("Id","Name","TypeDetail","Measurement","Price") values(1,'Колесо ВАЗ',3,'КГ',100);
INSERT INTO "Details" ("Id","Name","TypeDetail","Measurement","Price") values(2,'Рама ВАЗ',40,'КГ',40);
INSERT INTO "Details" ("Id","Name","TypeDetail","Measurement","Price") values(3,'Двигатель ВАЗ',100,'КГ',450);
INSERT INTO "Details" ("Id","Name","TypeDetail","Measurement","Price") values(4,'Ручник ВАЗ',200,'Г',25);

INSERT INTO "Tarifs" ("Id","CountPerHour") values(0,1);
INSERT INTO "Tarifs" ("Id","CountPerHour") values(1,2);
INSERT INTO "Tarifs" ("Id","CountPerHour") values(2,5);
INSERT INTO "Tarifs" ("Id","CountPerHour") values(3,10);

INSERT INTO "Standarts" ("Id","OperationId","ProfessionId","DischargeBuilder","TarifId","TimeEnsure","ValuePerTime") values(0,2,2,8,4,'18:00','2:00',0);
INSERT INTO "Standarts" ("Id","OperationId","ProfessionId","DischargeBuilder","TarifId","TimeEnsure","ValuePerTime") values(1,1,1,2,3,'20:30','5:00',3);
INSERT INTO "Standarts" ("Id","OperationId","ProfessionId","DischargeBuilder","TarifId","TimeEnsure","ValuePerTime") values(2,1,2,1,1,'7:00','7:00',2);
INSERT INTO "Standarts" ("Id","OperationId","ProfessionId","DischargeBuilder","TarifId","TimeEnsure","ValuePerTime") values(3,3,1,5,1,'18:30','2:40',1);
INSERT INTO "Standarts" ("Id","OperationId","ProfessionId","DischargeBuilder","TarifId","TimeEnsure","ValuePerTime") values(4,2,4,4,0,'21:00','0:30',4);

1) TASK
SELECT Standart."DetailId", Standart."OperationId", Standart."ProfessionId", Operation."Name", Standart."DischargeBuilder"
FROM "Standarts" AS Standart
INNER JOIN "Operations" AS Operation ON Standart."OperationId" = Operation."Id"
WHERE Standart."ProfessionId" = 1;
2)

SELECT "Name",COUNT(s."DetailId") FROM "Professions" as p
INNER JOIN "Standarts" as s ON s."ProfessionId" = p."Id"
GROUP BY "Name"

3)

SELECT p."Id", p."Name" FROM "Professions" as p
WHERE EXISTS (
    SELECT "Price"
    FROM "Details" as d
	WHERE d."Price">100 AND
        EXISTS (
        SELECT "Id"
        FROM "Standarts" as s
        WHERE s."ProfessionId" = p."Id" AND s."DischargeBuilder">4 AND s."DetailId" = d."Id"
    )
);

--Weather Observation Station 3 - Cidades distintas com id par
SELECT DISTINCT city 
FROM station 
WHERE id % 2 = 0;

--Weather Observation Station 4 - Diferenca entre total e cidades distintas
SELECT COUNT(city) - COUNT(DISTINCT city) AS contador 
FROM station;

--Weather Observation Station 5 - Menor nome ASC e maior nome DESC
SELECT TOP 1 city, LEN(city) FROM station 
WHERE LEN(city) = (SELECT MIN(LEN(city)) FROM station) 
ORDER BY city ASC;
SELECT TOP 1 city, LEN(city) FROM station 
WHERE LEN(city) = (SELECT MAX(LEN(city)) FROM station) 
ORDER BY city DESC;

--Weather Observation Station 7 - cidades distintas que terminam com a, e, i, o, u
SELECT DISTINCT city 
FROM station 
WHERE city LIKE("%[a,e,i,o,u]");

--Type of Triangle - classificar tipos de triangulos
SELECT 
CASE
    WHEN(A + B <= C) THEN "Not A Triangle" 
    WHEN(A + C <= B) THEN "Not A Triangle" 
    WHEN(B + C <= A) THEN "Not A Triangle" 
    WHEN(A = B AND A = C AND B = C) THEN "Equilateral" 
    WHEN(A = B AND A <> C) THEN "Isosceles" 
    WHEN(A = C AND A <> B) THEN "Isosceles" 
    WHEN(B = C AND B <> A) THEN "Isosceles" 
    WHEN(A <> B AND A <> C AND B <> C) THEN "Scalene" 
    ELSE "NA"
END AS tipo 
FROM Triangles;

--The PADS - classicar profissoes adcionando textos e abreviacoes
SELECT name + "(" + LEFT(occupation, 1) + ")" AS abreviacao 
FROM Occupations 
ORDER BY name;
SELECT "There are a total of " + CAST(COUNT(occupation) AS VARCHAR) + " " + LOWER(occupation) + "s." 
FROM Occupations 
GROUP BY occupation 
ORDER BY COUNT(occupation), occupation;

--Occupations - conta maximo de linhas de uma coluna e apresenta resultado tabulado em colunas por ocupacao
SELECT
    MAX(CASE WHEN Occupation = 'Doctor' THEN Name END) Doctor,
    MAX(CASE WHEN Occupation = 'Professor' THEN Name END) Professor,
    MAX(CASE WHEN Occupation = 'Singer' THEN Name END) Singer,
    MAX(CASE WHEN Occupation = 'Actor' THEN Name END) Actor
FROM (
    SELECT
        Name,
        Occupation,
        ROW_NUMBER() OVER (PARTITION BY Occupation ORDER BY Name) numeroDeLinhas
    FROM OCCUPATIONS
) subquery
GROUP BY numeroDeLinhas
ORDER BY numeroDeLinhas;

--Binary Tree Nodes - Classifica membros de uma arvore binaria
SELECT N, 
CASE
    WHEN P IS null THEN 'Root' 
    WHEN N IN (SELECT P FROM BST) THEN 'Inner'
    ELSE 'Leaf'
END
FROM BST
ORDER BY N

--New Companies - Diversas tabelas contando cargos
SELECT Com.company_code, founder,
    COUNT(DISTINCT lead_manager_code), 
    COUNT(DISTINCT senior_manager_code), 
    COUNT(DISTINCT manager_code), 
    COUNT(DISTINCT employee_code)
FROM Company Com
INNER JOIN Employee Emp ON Emp.company_code = Com.company_code
GROUP BY Com.company_code, founder
ORDER BY Com.company_code;
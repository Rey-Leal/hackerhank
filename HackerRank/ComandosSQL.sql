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

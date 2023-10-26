BEGIN TRANSACTION;

DECLARE @org_id INT;


-- creating an animal
SET @org_id=NEXT VALUE FOR Life.org_pk;
Print(@org_id)
INSERT INTO Life.Organism(
    org_id,
    avg_lifespan,
    species,
    colour)
VALUES(
    @org_id,
    20,
    "Felis catus",
    "Black"
);
PRINT(@org_id)
INSERT INTO Life.Animal(
    org_id,
    food_type)
VALUES(
    @org_id,
    "Carnivore"
);


-- creating a plant
SET @org_id=NEXT VALUE FOR Life.org_pk;
Print(@org_id)
INSERT INTO Life.Organism(
    org_id,
    avg_lifespan,
    species,
    colour)
VALUES(
    @org_id,
    2,
    "Zea mays",
    "Yellow"
);
PRINT(@org_id)
INSERT INTO Life.Plant(
    org_id,
    chlorophyll_production)
VALUES(
    @org_id,
    3.2
);

COMMIT;

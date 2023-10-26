BEGIN TRANSACTION;

DECLARE @org_id INT;

COMMIT;

-- creating an animal
SET @org_id=NEXT VALUE FOR Life.org_pk;
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
INSERT INTO Life.Animal(
    org_id,
    food_type)
VALUES(
    @org_id,
    "Carnivore"
);


-- creating a plant
SET @org_id=NEXT VALUE FOR Life.org_pk;
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
INSERT INTO Life.Plant(
    org_id,
    chlorophyll_production)
VALUES(
    @org_id,
    3.2
);

COMMIT;

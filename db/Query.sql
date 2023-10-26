SELECT o.species 
FROM Life.Organism AS o, Life.Animal AS a
WHERE o.org_id=a.org_id AND a.food_type="Carnivore";
SELECT * FROM plants


create table plants (
name varchar(255) NOT NULL,
maturity varchar(255) NOT NULL,
size varchar(255) NOT NULL,
sun varchar(255) NOT NULL,
spread varchar(255) NOT NULL,
height varchar(255) NOT NULL,
description varchar(max) NOT NULL,
CONSTRAINT PK_Name PRIMARY KEY (name)
);

INSERT INTO plants VALUES( 'Bean', '75 days', '6 inches', 'Full Sun', '18 inches', '24 inches', 'Beans are the unripe, young fruit and protective pods of various cultivars of the common bean . Immature or young pods of the runner bean, yardlong bean, and hyacinth bean are used in a similar way. Green beans are known by many common names, including French Beans, string beans, snap beans, and snaps.');
INSERT INTO plants VALUES( 'Carrot', '65 days', '6 inches', 'Full Sun', '3 inches', '4-8 inches', 'The carrot is a root vegetable, usually orange in color, though purple, black, red, white, and yellow cultivars exist. Carrots are a domesticated form of the wild carrot native to Europe and southwestern Asia. The plant probably originated in Persia and was originally cultivated for its leaves and seeds. The most commonly eaten part of the plant is the taproot, although the greens are sometimes eaten as well. The domestic carrot has been selectively bred for its greatly enlarged, more palatable, less woody-textured taproot.');
INSERT INTO plants VALUES('Cucumber', '50 days', '6-8 inches', 'Full Sun', '60 inches' , '60 inches', 'Cucumber is a widely cultivated plant in the gourd family, Cucurbitaceae. It is a creeping vine that bears cucumiform fruits that are used as vegetables. There are three main varieties of cucumber: slicing, pickling, and seedless. Within these varieties, several cultivars have been created. In North America, the term "wild cucumber" refers to plants in the genera Echinocystis and Marah, but these are not closely related. The cucumber is originally from South Asia, but now grows on most continents. Many different types of cucumber are traded on the global market.');
INSERT INTO plants VALUES('Lettuce', '50 days', '10-12 inches', 'Full Sun, Part Sun', '10-12 inches', '7 inches', 'Generally grown as a hardy annual, lettuce is easily cultivated, although it requires relatively low temperatures to prevent it from flowering quickly. It can be plagued by numerous nutrient deficiencies, as well as insect and mammal pests, and fungal and bacterial diseases. L. sativacrosses easily within the species and with some other species within the Lactuca genus. Although this trait can be a problem to home gardeners who attempt to save seeds, biologists have used it to broaden the gene pool of cultivated lettuce varieties. ');
INSERT INTO plants VALUES('Onion', '110 days', '4 inches', 'Full Sun', '4 inches', '12-14 inches', 'The onion plant has a fan of hollow, bluish-green leaves and its bulb at the base of the plant begins to swell when a certain day-length is reached. The bulbs are composed of shortened, compressed, underground stems surrounded by fleshy modified scale (leaves) that envelop a central bud at the tip of the stem. In the autumn (or in spring, in the case of overwintering onions), the foliage dies down and the outer layers of the bulb become dry and brittle. The crop is harvested and dried and the onions are ready for use or storage. The crop is prone to attack by a number of pests and diseases, particularly the onion fly, the onion eelworm, and various fungi cause rotting. Some varieties of A. cepa, such as shallots and potato onions, produce multiple bulbs.');
INSERT INTO plants VALUES('Peas', '70 days', '4 inches', 'Full Sun, Part Sun', '6-8 inches', '2-3 feet', 'P. sativum is an annual plant, with a life cycle of one year. It is a cool-season crop grown in many parts of the world; planting can take place from winter to early summer depending on location. The average pea weighs between 0.1 and 0.36 grams.The immature peas (and in snow peasthe tender pod as well) are used as a vegetable, fresh, frozen or canned; varieties of the species typically called field peas are grown to produce dry peas like the split pea shelled from the matured pod. These are the basis of pease porridge and pea soup, staples of medieval cuisine; in Europe, consuming fresh immature green peas was an innovation of Early Modern cuisine.');
INSERT INTO plants VALUES('Pepper', '75 days', '4 inches', 'Full Sun', '12 inches', '18-24 inches', 'The bell pepper (also known as sweet pepper or pepper in the United Kingdom, Canada and Ireland, and capsicum in Australia, India, Pakistan, Bangladesh, Singapore and New Zealand) is a cultivar group of the species Capsicum annuum. Cultivars of the plant produce fruits in different colors, including red, yellow, orange, green, chocolate/brown, vanilla/white, and purple. Bell peppers are sometimes grouped with less pungent pepper varieties as "sweet peppers". The whitish ribs and seeds inside bell peppers may be consumed, but some people find the taste to be bitter.');
INSERT INTO plants VALUES('Tomato', '70 days', '4 inches', 'Full Sun', '38 inches', '18 inches', 'Its use as a food originated in Mexico, and spread throughout the world following the Spanish colonization of the Americas. Tomato is consumed in diverse ways, including raw, as an ingredient in many dishes, sauces, salads, and drinks. While tomatoes are botanically berry-type fruits, they are considered culinary vegetables, being ingredients of savory meals.');
INSERT INTO plants VALUES('Zucchini', '40 days', '7-8 inches', 'Full Sun', '60-72 inches', '28-30 inches', 'Zucchini, like all squash, has its ancestry in the Americas. However, the varieties of squash typically called "zucchini" were developed in northern Italy in the second half of the 19th century, many generations after the introduction of cucurbits from the Americas in the early 16th century.');

create table plantuserinfo (
name varchar(255) NOT NULL,
count int,
dateplanted date,
expectedmaturity date,
CONSTRAINT PK_plantName PRIMARY KEY (name)
);
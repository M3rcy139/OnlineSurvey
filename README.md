INSERT INTO "Survey" ("Id", "Title", "Description") VALUES
    ('b8943065-5a94-41e5-b437-df28eb1e2422', 'Опрос о предпочтениях', 'Опрос для выяснения предпочтений пользователей');

INSERT INTO "Interviews" ("Id", "StartedAt", "CompletedAt", "UserId", "SurveyId")
VALUES
    ('c22b7b26-9d63-47f9-9ac7-f2b9f12b6f2a', '2024-09-26 10:00:00', NULL, 'f4b23a7e-e4b2-4b4a-b812-4d9a237f792a', 'b8943065-5a94-41e5-b437-df28eb1e2422');

INSERT INTO "Questions" ("Id", "Text", "SurveyId") VALUES
    ('1', 'Какой ваш любимый цвет?', 'b8943065-5a94-41e5-b437-df28eb1e2422'),
    ('2', 'Какой ваш любимый фильм?', 'b8943065-5a94-41e5-b437-df28eb1e2422'),
    ('3', 'Какой ваш любимый сезон года?', 'b8943065-5a94-41e5-b437-df28eb1e2422'),
    ('4', 'Какой ваш любимый жанр музыки?', 'b8943065-5a94-41e5-b437-df28eb1e2422'),
    ('5', 'Какой ваш любимый напиток?', 'b8943065-5a94-41e5-b437-df28eb1e2422');

INSERT INTO "Answers" ("Id", "Text", "QuestionId") VALUES
    (1, 'Красный', '1'),
    (2, 'Синий', '1'),
    (3, 'Зелёный', '1'),
    (4, 'Жёлтый', '1');

INSERT INTO "Answers" ("Id", "Text", "QuestionId") VALUES
    (5, 'Интерстеллар', '2'),
    (6, 'Начало', '2'),
    (7, 'Матрица', '2'),
    (8, 'Форрест Гамп', '2');


INSERT INTO "Answers" ("Id", "Text", "QuestionId") VALUES
    (9, 'Зима', '3'),
    (10, 'Весна', '3'),
    (11, 'Лето', '3'),
    (12, 'Осень', '3');


INSERT INTO "Answers" ("Id", "Text", "QuestionId") VALUES
    (13, 'Рок', '4'),
    (14, 'Поп', '4'),
    (15, 'Классическая', '4'),
    (16, 'Джаз', '4');


INSERT INTO "Answers" ("Id", "Text", "QuestionId") VALUES
    (17, 'Кофе', '5'),
    (18, 'Чай', '5'),
    (19, 'Сок', '5'),
    (20, 'Вода', '5');


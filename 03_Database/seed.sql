
INSERT INTO roles (name)
VALUES
('ADMIN'),
('WAITER'),
('CUSTOMER');

INSERT INTO menu_categories (name, description)
VALUES
('Bebidas', 'Bebidas frías y calientes'),
('Hamburguesas', 'Hamburguesas artesanales'),
('Postres', 'Postres del restaurante');

INSERT INTO restaurant_tables (table_number, capacity)
VALUES
(1, 4),
(2, 2),
(3, 6);

-- Usuario administrador ejemplo
INSERT INTO users (
    role_id,
    first_name,
    last_name,
    email,
    password_hash
)
VALUES (
    (SELECT id FROM roles WHERE name = 'ADMIN'),
    'Admin',
    'SIGR',
    'admin@sigr.com',
    'HASH_PASSWORD'
);

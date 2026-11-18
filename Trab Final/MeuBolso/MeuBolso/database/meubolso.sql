-- =====================================================================
--  MeuBolso — Controle Financeiro Pessoal
--  Script do banco de dados (SQLite)
--
--  O programa executa este script automaticamente na primeira vez que
--  roda, criando o arquivo meubolso.db. Também pode ser aberto em
--  qualquer ferramenta de SQLite (ex.: DB Browser for SQLite).
-- =====================================================================

PRAGMA foreign_keys = ON;

-- ---------------------------------------------------------------------
--  TABELAS
-- ---------------------------------------------------------------------

-- tipo: 1 = Receita, 2 = Despesa
CREATE TABLE IF NOT EXISTS categorias (
    id      INTEGER PRIMARY KEY AUTOINCREMENT,
    nome    TEXT    NOT NULL UNIQUE COLLATE NOCASE,
    tipo    INTEGER NOT NULL CHECK (tipo IN (1, 2))
);

CREATE TABLE IF NOT EXISTS contas (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    nome            TEXT    NOT NULL,
    saldo_inicial   REAL    NOT NULL DEFAULT 0
);

-- data no formato AAAA-MM-DD
CREATE TABLE IF NOT EXISTS lancamentos (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    tipo            INTEGER NOT NULL CHECK (tipo IN (1, 2)),
    descricao       TEXT    NOT NULL,
    valor           REAL    NOT NULL CHECK (valor > 0),
    data            TEXT    NOT NULL,
    categoria_id    INTEGER NOT NULL REFERENCES categorias (id),
    conta_id        INTEGER NOT NULL REFERENCES contas (id)
);

CREATE TABLE IF NOT EXISTS metas (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    descricao       TEXT    NOT NULL,
    valor_alvo      REAL    NOT NULL CHECK (valor_alvo > 0),
    valor_atual     REAL    NOT NULL DEFAULT 0 CHECK (valor_atual >= 0),
    prazo           TEXT    NOT NULL
);

CREATE INDEX IF NOT EXISTS ix_lancamentos_data ON lancamentos (data);

-- ---------------------------------------------------------------------
--  DADOS DE EXEMPLO
-- ---------------------------------------------------------------------

INSERT INTO categorias (id, nome, tipo) VALUES
    (1, 'Salário',      1),
    (2, 'Renda extra',  1),
    (3, 'Moradia',      2),
    (4, 'Alimentação',  2),
    (5, 'Transporte',   2),
    (6, 'Lazer',        2);

INSERT INTO contas (id, nome, saldo_inicial) VALUES
    (1, 'Nubank',   500.00),
    (2, 'Dinheiro', 120.00),
    (3, 'Poupança', 2000.00);

INSERT INTO lancamentos (tipo, descricao, valor, data, categoria_id, conta_id) VALUES
    (1, 'Salário',   4800.00, '2026-11-05', 1, 1),
    (2, 'Aluguel',   1400.00, '2026-11-07', 3, 1),
    (2, 'Mercado',    685.40, '2026-11-10', 4, 1),
    (2, 'Gasolina',   230.00, '2026-11-12', 5, 2),
    (2, 'Cinema',      64.00, '2026-11-14', 6, 1),
    (1, 'Freela',     350.00, '2026-11-15', 2, 1),
    (1, 'Salário',   4800.00, '2026-12-05', 1, 1),
    (2, 'Aluguel',   1400.00, '2026-12-07', 3, 1),
    (2, 'Mercado',    742.10, '2026-12-09', 4, 1),
    (2, 'Presentes',  380.00, '2026-12-18', 6, 1);

INSERT INTO metas (descricao, valor_alvo, valor_atual, prazo) VALUES
    ('Reserva de emergência', 10000.00, 2000.00, '2027-11-01'),
    ('Viagem de férias',       5000.00, 3250.00, '2027-01-01');

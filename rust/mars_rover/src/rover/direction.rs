pub enum Direction {
    North,
    East,
    South,
    West
}

impl Direction {
    pub fn rotate_right(self) -> Direction {
        match self {
            Direction::North => Direction::East,
            Direction::East => Direction::South,
            Direction::South => Direction::West,
            _ => panic!("not yet implemented")
        }
    }

    pub fn to_string(self) -> char {
        match self {
            Direction::North => 'N',
            Direction::East => 'E',
            Direction::South => 'S',
            Direction::West => 'W',
        }
    }
}


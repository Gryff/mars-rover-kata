 use std::fmt;
 use std::fmt::Display;

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
            Direction::West => Direction::North
        }
    }
    
    pub fn rotate_left(self) -> Direction {
        match self {
            Direction::North => Direction::West,
            Direction::West => Direction::South,
            Direction::South => Direction::East,
            Direction::East => Direction::North
        }
    }
}

impl Display for Direction {
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{}", match self {
            Direction::North => 'N',
            Direction::East => 'E',
            Direction::South => 'S',
            Direction::West => 'W',
        })
    }
}


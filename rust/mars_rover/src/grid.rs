use direction::Direction;

pub struct Grid {
    pub x: i32,
    pub y: i32
}

impl Grid {
    pub fn new(x: i32, y: i32) -> Grid {
        Grid { x: x, y: y }
    }

    pub fn position_at(self, direction: &Direction) -> Grid {
        match direction {
            Direction::North => Grid { x: self.x, y: modulo_ten(self.y + 1) },
            Direction::East => Grid { x: modulo_ten(self.x + 1), y: self.y },
            Direction::South => Grid { x: self.x, y: modulo_ten(self.y - 1) },
            Direction::West => Grid { x: modulo_ten(self.x - 1), y: self.y }
        }
    }

    pub fn to_string(self) -> String {
        format!("{},{}", self.x, self.y)
    }
}

fn modulo_ten(n: i32) -> i32 {
    ((n % 10) + 10) % 10
}

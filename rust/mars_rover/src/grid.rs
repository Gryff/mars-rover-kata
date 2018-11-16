use direction;

pub struct Grid {
    pub x: i32,
    pub y: i32
}

impl Grid {
    pub fn new(x: i32, y: i32) -> Grid {
        Grid { x: x, y: y }
    }

    pub fn position_at(self, direction: &direction::Direction) -> Grid {
        match direction {
            direction::Direction::North => Grid { x: self.x, y: (self.y + 1) % 10 },
            direction::Direction::East => Grid { x: (self.x + 1) % 10, y: self.y },
            _ => panic!("I can't move in this direction yet")
        }
    }

    pub fn to_string(self) -> String {
        format!("{},{}", self.x, self.y)
    }
}

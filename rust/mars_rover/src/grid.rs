use direction;

pub struct Grid {
    pub x: i32,
    pub y: i32
}

impl Grid {
    pub fn position_at(self, direction: &direction::Direction) -> Grid {
        match direction {
            direction::Direction::North => Grid { x: self.x, y: (self.y + 1) % 10 },
            direction::Direction::East => Grid { x: (self.x + 1) % 10, y: self.y },
            _ => panic!("I can't move in this direction yet")
        }
    }
}

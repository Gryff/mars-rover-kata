mod direction;
mod grid;
use std::fmt;
use std::fmt::Display;

use grid::Grid;
use direction::Direction;

fn main() {
    go("");
}

struct Location {
    position: Grid,
    direction: Direction,
}

impl Location {
    fn move_forward (self) -> Location {
        Location {
            position: self.position.position_at(&self.direction),
            direction: self.direction
        }
    }

    fn rotate_left(self) -> Location {
        Location {
            position: self.position,
            direction: self.direction.rotate_left()
        }
    }

    fn rotate_right(self) -> Location {
        Location {
            position: self.position,
            direction: self.direction.rotate_right()
        }
    }
}

impl Display for Location {
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{},{}", self.position, self.direction)
    }
}

fn go(commands: &str) -> String {
    let starting_position = Grid::new(0, 0);
    let starting_direction = Direction::North;
    let starting_location = Location { position: starting_position, direction: starting_direction };

    let final_location = commands
        .chars()
        .fold(starting_location, execute_command);

    format!("{}", final_location)
}

fn execute_command(location: Location, command: char) -> Location {
    if command == 'M' {
        location.move_forward()
    } else if command == 'R' {
        location.rotate_right()
    } else if command == 'L' {
        location.rotate_left()
    } else {
        unreachable!("this should never happen")
    }
}

#[cfg(test)]
mod rover_tests {
    use super::*;

    #[test]
    fn starts_at_0_0_n() {
        assert_eq!(go(""), "0,0,N");
    }

    #[test]
    fn can_move_north() {
        assert_eq!(go("M"), "0,1,N");
    }

    #[test]
    fn can_move_north_twice() {
        assert_eq!(go("MM"), "0,2,N");
    }

    #[test]
    fn wraps_around_grid_moving_north() {
        assert_eq!(go("MMMMMMMMMMMM"), "0,2,N");
    }

    #[test]
    fn can_rotate_right() {
        assert_eq!(go("R"), "0,0,E");
        assert_eq!(go("RR"), "0,0,S");
        assert_eq!(go("RRR"), "0,0,W");
        assert_eq!(go("RRRR"), "0,0,N");
    }

    #[test]
    fn can_rotate_left() {
        assert_eq!(go("L"), "0,0,W");
        assert_eq!(go("LL"), "0,0,S");
        assert_eq!(go("LLL"), "0,0,E");
        assert_eq!(go("LLLL"), "0,0,N");
    }

    #[test]
    fn can_move_east() {
        assert_eq!(go("RM"), "1,0,E");
        assert_eq!(go("RMMM"), "3,0,E");
    }

    #[test]
    fn can_wrap_around_east() {
        assert_eq!(go("RMMMMMMMMMMMM"), "2,0,E");
    }

    #[test]
    fn can_move_south() {
        assert_eq!(go("MMRRM"), "0,1,S");
    }

    #[test]
    fn can_wrap_around_south() {
        assert_eq!(go("RRMM"), "0,8,S");
    }

    #[test]
    fn can_move_west() {
        assert_eq!(go("RMMLLM"), "1,0,W");
    }

    #[test]
    fn can_wrap_around_west() {
        assert_eq!(go("LMM"), "8,0,W");
    }

    #[test]
    fn lots_of_combined_commands() {
        assert_eq!(go("MMRMLRMMMLLLM"), "4,1,S");
    }
}

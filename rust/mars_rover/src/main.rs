mod direction;
mod grid;

use grid::Grid;
use direction::Direction;

fn main() {
    go("");
}

fn go(commands: &str) -> String {
    let starting_position = Grid::new(0, 0);
    let starting_direction = Direction::North;

    let (final_position, final_direction) = commands
        .chars()
        .fold((starting_position, starting_direction), execute_command);

    format!("{},{}", final_position.to_string(), final_direction.to_string())
}

fn execute_command((grid, direction): (Grid, Direction), command: char) -> (Grid, Direction) {
    if command == 'M' {
        (grid.position_at(&direction), direction)
    } else if command == 'R' {
        (grid, direction.rotate_right())
    } else if command == 'L' {
        (grid, direction.rotate_left())
    } else {
        panic!("this should never happen")
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

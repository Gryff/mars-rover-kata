mod direction;
mod grid;

fn main() {
    go("");
}

fn go(commands: &str) -> String {
    let mut grid = grid::Grid { x: 0, y: 0 };
    let mut direction = direction::Direction::North;

    for command in commands.chars() {
        if command == 'M' {
            grid = grid.position_at(&direction);
        }

        if command == 'R' {
            direction = direction.rotate_right();
        }

        if command == 'L' {
            direction = direction.rotate_left();
        }
    }

    format!("{},{},{}", grid.x, grid.y, direction.to_string())
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
}

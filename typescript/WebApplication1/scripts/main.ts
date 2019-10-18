interface IPoint
{
    getDist(): number;
}


module Shapes
{
    export class Point implements IPoint
    {
        getDist() {
            return 33;
        }
    }
}


module Shapes2
{
    export class Point implements IPoint
    {
        getDist() {
            return 33;
        }
    }
}

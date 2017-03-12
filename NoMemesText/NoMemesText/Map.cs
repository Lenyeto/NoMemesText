using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMemesText
{


    class Map
    {
        static Map m_instance;
        private List<List<Cell>> m_cells;
        private int map_size_x;
        private int map_size_y;

        private Map()
        {
            m_cells = new List<List<Cell>>();

            populateCells(20, 20);
        }

        public static Map getInstance()
        {
            if (m_instance == null)
            {
                m_instance = new Map();
            }
            return m_instance;
        }

        public int getMapWidth()
        {
            return map_size_x;
        }

        public int getMapHeight()
        {
            return map_size_y;
        }

        private void populateCells(int x_size, int y_size)
        {
            map_size_x = x_size;
            map_size_y = y_size;

            Random r = new Random();

            for (int x = 0; x < x_size; x++)
            {
                m_cells.Add(new List<Cell>());
                for (int y = 0; y < y_size; y++)
                {
                    Cell tmpCell = new Cell();

                    if (r.Next(100) > 60)
                    {
                        tmpCell.m_type = Cell.Type.Road;
                    }
                    else
                    {
                        tmpCell.m_type = Cell.Type.Blank;
                    }

                    m_cells[x].Add(tmpCell);


                }
            }
        }

        public void createFOGMap(User u)
        {
            using (Bitmap b = new Bitmap(map_size_x * 32, map_size_y * 32))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.Black);

                    foreach (Coords c in u.visited)
                    {
                        int x = c.x;
                        int y = c.y;
                        int pixelX = x * 32;
                        int pixelY = y * 32;
                        if (x == 0 || y == 0 || x == map_size_x - 1 || y == map_size_y - 1)
                        {
                            g.DrawImage(Image.FromFile("../media/TileSet/Grass.png"), new Point(pixelX, pixelY));
                        }
                        else
                        {
                            if (m_cells[x][y].m_type == Cell.Type.Road)
                            {
                                if (m_cells[x - 1][y].m_type == Cell.Type.Road)
                                {
                                    if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                    {
                                        if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                        {
                                            if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/All.png"), new Point(pixelX, pixelY));
                                            }
                                            else
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpLeftRight.png"), new Point(pixelX, pixelY));
                                            }
                                        }
                                        else if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftDownRight.png"), new Point(pixelX, pixelY));
                                        }
                                        else
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftRight.png"), new Point(pixelX, pixelY));
                                        }
                                    }
                                    else if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                    {
                                        if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpLeftDown.png"), new Point(pixelX, pixelY));
                                        }
                                        else
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftDown.png"), new Point(pixelX, pixelY));
                                        }

                                    }
                                    else if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpLeft.png"), new Point(pixelX, pixelY));
                                    }
                                    else
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/RightDead.png"), new Point(pixelX, pixelY));
                                    }
                                }
                                else if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                {
                                    if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                    {

                                        if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpRightDown.png"), new Point(pixelX, pixelY));
                                        }
                                        else
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpDown.png"), new Point(pixelX, pixelY));
                                        }
                                    }
                                    else if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpRight.png"), new Point(pixelX, pixelY));
                                    }
                                    else
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/DownDead.png"), new Point(pixelX, pixelY));
                                    }
                                }
                                else if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                {
                                    if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/DownRight.png"), new Point(pixelX, pixelY));
                                    }
                                    else
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpDead.png"), new Point(pixelX, pixelY));
                                    }
                                }
                                else if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                {
                                    g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftDead.png"), new Point(pixelX, pixelY));
                                }
                                else
                                {
                                    g.DrawImage(Image.FromFile("../media/TileSet/Paths/DeadAll.png"), new Point(pixelX, pixelY));
                                }

                            }
                            else
                            {
                                g.DrawImage(Image.FromFile("../media/TileSet/Grass.png"), new Point(pixelX, pixelY));
                            }
                        }
                    }

                }


                try
                {
                    b.Save("../media/tmpMap.png", ImageFormat.Png);
                    b.Save("../media/tmpMap.jpeg", ImageFormat.Jpeg);

                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
            }
        }

        public void createImage()
        {
            using (Bitmap b = new Bitmap(map_size_x * 32, map_size_y * 32))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.Green);

                    for (int x = 0; x < map_size_x; x++)
                    {
                        int pixelX = x * 32;
                        for (int y = 0; y < map_size_y; y++)
                        {
                            int pixelY = y * 32;
                            if (x == 0 || y == 0 || x == map_size_x - 1 || y == map_size_y - 1)
                            {
                                g.DrawImage(Image.FromFile("../media/TileSet/Grass.png"), new Point(pixelX, pixelY));
                            } else
                            {
                                if (m_cells[x][y].m_type == Cell.Type.Road)
                                {
                                    if (m_cells[x - 1][y].m_type == Cell.Type.Road)
                                    {
                                        if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                        {
                                            if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                            {
                                                if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                                {
                                                    g.DrawImage(Image.FromFile("../media/TileSet/Paths/All.png"), new Point(pixelX, pixelY));
                                                } else
                                                {
                                                    g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpLeftRight.png"), new Point(pixelX, pixelY));
                                                }
                                            } else if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftDownRight.png"), new Point(pixelX, pixelY));
                                            } else 
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftRight.png"), new Point(pixelX, pixelY));
                                            }
                                        } else if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                        {
                                            if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpLeftDown.png"), new Point(pixelX, pixelY));
                                            } else
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftDown.png"), new Point(pixelX, pixelY));
                                            }
                                            
                                        } else if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpLeft.png"), new Point(pixelX, pixelY));
                                        } else 
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/RightDead.png"), new Point(pixelX, pixelY));
                                        }
                                    } else if (m_cells[x][y - 1].m_type == Cell.Type.Road)
                                    {
                                        if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                        {

                                            if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpRightDown.png"), new Point(pixelX, pixelY));
                                            }
                                            else
                                            {
                                                g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpDown.png"), new Point(pixelX, pixelY));
                                            }
                                        } else if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpRight.png"), new Point(pixelX, pixelY));
                                        }
                                        else
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/DownDead.png"), new Point(pixelX, pixelY));
                                        }
                                    } else if (m_cells[x][y + 1].m_type == Cell.Type.Road)
                                    {
                                        if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/DownRight.png"), new Point(pixelX, pixelY));
                                        } else
                                        {
                                            g.DrawImage(Image.FromFile("../media/TileSet/Paths/UpDead.png"), new Point(pixelX, pixelY));
                                        }
                                    } else if (m_cells[x + 1][y].m_type == Cell.Type.Road)
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/LeftDead.png"), new Point(pixelX, pixelY));
                                    } else
                                    {
                                        g.DrawImage(Image.FromFile("../media/TileSet/Paths/DeadAll.png"), new Point(pixelX, pixelY));
                                    }

                                } else
                                {
                                    g.DrawImage(Image.FromFile("../media/TileSet/Grass.png"), new Point(pixelX, pixelY));
                                }
                            }
                            //g.DrawImage(Image.FromFile())
                        }
                    }

                    //g.DrawImage(Image.FromFile("tmpTile.png"), new Point(0, 0));
                }


                //b.Save(@"C:\green.png", ImageFormat.Png);
                try
                {
                    b.Save("../media/tmpMap.png", ImageFormat.Png);
                    b.Save("../media/tmpMap.jpeg", ImageFormat.Jpeg);
                    
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                
            }
        }

        public Cell getCell(int x, int y)
        {
            return m_cells[x][y];
        }
    }

    class Cell
    {
        public enum Type
        {
            Blank = 0, Road = 1, Trees = 2
        }

        public Type m_type;

        public Cell()
        {
            
        }
    }
}

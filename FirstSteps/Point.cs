using System;

namespace CsharpStudyApp.FirstSteps
{
    public struct Point : IChangeBoxingPoint
    {
        private Int32 m_x;
        private Int32 m_y;

        public Point(int mX, int mY)
        {
            m_x = mX;
            m_y = mY;
        }
        
        public void Change(Int32 m_x, Int32 m_y)
        {
            this.m_x = m_x;
            this.m_y = m_y;
        }

        public override string ToString()
        {
            return $"{nameof(m_x)}: {m_x}, {nameof(m_y)}: {m_y}";
        }
    }
    
}
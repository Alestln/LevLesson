using System.Collections;

namespace LevLesson
{
    internal class EnemyWaveIterator : IEnumerator<Enemy>
    {
        private readonly List<Enemy> _vanguard;
        private readonly List<Enemy> _reinforcements;

        private int _currentIndex = -1;
        private bool _inVanguard = true;

        public EnemyWaveIterator(List<Enemy> vanguard, List<Enemy> reinforcements)
        {
            _vanguard = vanguard;
            _reinforcements = reinforcements;
        }

        public Enemy Current
        {
            get
            {
                if (_inVanguard)
                {
                    return _vanguard[_currentIndex];
                }
                else
                {
                    return _reinforcements[_currentIndex];
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            _currentIndex++;

            if (_inVanguard)
            {
                if (_currentIndex < _vanguard.Count)
                {
                    return true;
                }
                else
                {
                    _inVanguard = false;
                    _currentIndex = 0;
                }
            }

            if (!_inVanguard)
            {
                if (_currentIndex < _reinforcements.Count)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
            _inVanguard = true;
        }
    }
}

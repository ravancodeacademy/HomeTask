using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject.Models;

internal class Weapon(int maxBulletCount, int currentBulletCount, WeaponFireMode fireMode)
{
    private const float BulletFireInSeconds = 0.5f;
    private int _maxBulletCount = maxBulletCount;
    private int _currentBulletCount = currentBulletCount;
    private WeaponFireMode _fireMode = fireMode;

    public bool Shoot()
    {
        if (_currentBulletCount == 0)
        {
            return false;
        }
        _currentBulletCount--;
        return true;
    }

    public float Fire()
    {
        float secondsTookToFire = _currentBulletCount * BulletFireInSeconds;
        _currentBulletCount = 0;
        return secondsTookToFire;
    }

    public int GetNeededBulletCount()
    {
        return _maxBulletCount - _currentBulletCount;
    }

    public void Reload()
    {
        _currentBulletCount = _maxBulletCount;
    }

    public WeaponFireMode ChangeFireMode()
    {
        _fireMode = _fireMode == WeaponFireMode.single ? WeaponFireMode.auto : WeaponFireMode.single;
        return _fireMode;
    }


    public string GetInfo()
    {
        return $"Max bullet count: {_maxBulletCount}\nCurrent bullet count:{_currentBulletCount}\nFire mode:{_fireMode}";
    }
}

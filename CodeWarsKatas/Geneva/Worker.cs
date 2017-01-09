﻿using System;
using System.Collections.Generic;

public class Worker : IDisposable
{
    private List<string> tasks = new List<string>();

    public int Id { get; private set; }

    public IEnumerable<string> Tasks { get { return this.tasks; } }

    public Worker(int id)
    {
        this.Id = id;
    }

    public void PerformTask(string task)
    {
        if (this.tasks == null)
            throw new ObjectDisposedException(this.GetType().Name);

        this.tasks.Add(task);
    }

    public void Dispose()
    {
        
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            this.Dispose();
        }
        // free native resources if there are any.
    }
}
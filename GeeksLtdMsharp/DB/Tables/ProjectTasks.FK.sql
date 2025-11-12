ALTER TABLE ProjectTasks ADD Constraint
                [FK_ProjectTask.Project]
                FOREIGN KEY (Project)
                REFERENCES Projects (ID)
                ON DELETE NO ACTION;
GO
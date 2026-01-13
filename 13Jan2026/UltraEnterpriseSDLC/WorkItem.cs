using System;
using System.Collections.Generic;
using System.Linq;

namespace _13Jan2026.UltraEnterpriseSDLC
{
    public enum RiskLevel { Low, Medium, High, Critical }
    public enum SDLCStage { BackLog, Requirement, Design, Development, CodeReview, Testing, UAT, Deployment, Maintaince }

    public sealed class Requirement
    {
        public int Id { get; }
        public string Title { get; }
        public RiskLevel Risk { get; }

        public Requirement(int id, string title, RiskLevel risk)
        {
            Id = id;
            Title = title;
            Risk = risk;
        }
    }

    public sealed class WorkItem
    {
        public int Id { get; }
        public string Name { get; }
        public SDLCStage Stage { get; set; }
        public HashSet<int> DependencyIds { get; }

        public WorkItem(int id, string name, SDLCStage stage)
        {
            Id = id;
            Name = name;
            Stage = stage;
            DependencyIds = new HashSet<int>();
        }
    }

    public sealed class BuildSnapshot
    {
        public string Version { get; }
        public DateTime Timestamp { get; }

        public BuildSnapshot(string version)
        {
            Version = version;
            Timestamp = DateTime.UtcNow;
        }
    }

    public sealed class AuditLog
    {
        public DateTime Time { get; }
        public string Action { get; }

        public AuditLog(string action)
        {
            Time = DateTime.UtcNow;
            Action = action;
        }
    }

    public sealed class QualityMetric
    {
        public string Name { get; }
        public double Score { get; }

        public QualityMetric(string name, double score)
        {
            Name = name;
            Score = score;
        }
    }

    public class EnterpriseSDLCEngine
    {
        private List<Requirement> _requirements;
        private Dictionary<int, WorkItem> _workItemRegistry;
        private SortedDictionary<SDLCStage, List<WorkItem>> _stageBoard;
        private Queue<WorkItem> _executionQueue;
        private Stack<BuildSnapshot> _rollbackStack;
        private HashSet<string> _uniqueTestSuites;
        private LinkedList<AuditLog> _auditLedger;
        private SortedList<double, QualityMetric> _releaseScoreboard;
        private int _requirementCounter;
        private int _workItemCounter;

        public EnterpriseSDLCEngine()
        {
            _requirements = new List<Requirement>();
            _workItemRegistry = new Dictionary<int, WorkItem>();
            _stageBoard = new SortedDictionary<SDLCStage, List<WorkItem>>();
            _executionQueue = new Queue<WorkItem>();
            _rollbackStack = new Stack<BuildSnapshot>();
            _uniqueTestSuites = new HashSet<string>();
            _auditLedger = new LinkedList<AuditLog>();
            _releaseScoreboard = new SortedList<double, QualityMetric>();
        }

        public void AddRequirement(string title, RiskLevel risk)
        {
            Requirement requirement = new Requirement(_requirementCounter, title, risk);
            _requirementCounter++;
            _requirements.Add(requirement);
            _auditLedger.AddLast(
                new AuditLog($"Requirement added: {requirement.Id} - {requirement.Title} ({requirement.Risk})")
            );
        }

        public WorkItem CreateWorkItem(string name, SDLCStage stage)
        {
            WorkItem workItem = new WorkItem(_workItemCounter, name, stage);
            _workItemCounter++;

            _workItemRegistry.Add(workItem.Id, workItem);

            if (!_stageBoard.ContainsKey(stage))
                _stageBoard[stage] = new List<WorkItem>();

            _stageBoard[stage].Add(workItem);

            _auditLedger.AddLast(
                new AuditLog($"WorkItem created: {workItem.Name} at stage {workItem.Stage}")
            );

            return workItem;
        }

        public void AddDependency(int workItemId, int dependsOnId)
        {
            if (!_workItemRegistry.ContainsKey(workItemId))
                throw new InvalidOperationException($"WorkItem {workItemId} does not exist.");

            if (!_workItemRegistry.ContainsKey(dependsOnId))
                throw new InvalidOperationException($"Dependency {dependsOnId} does not exist.");

            WorkItem workItem = _workItemRegistry[workItemId];
            workItem.DependencyIds.Add(dependsOnId);

            _auditLedger.AddLast(
                new AuditLog($"Dependency added: WorkItem {workItemId} depends on WorkItem {dependsOnId}")
            );
        }

        public void PlanStage(SDLCStage stage)
        {
            if (!_stageBoard.ContainsKey(stage))
                return;

            var eligible = _stageBoard[stage]
                .Where(wi =>
                    wi.DependencyIds.All(depId =>
                        _workItemRegistry[depId].Stage > stage
                    )
                );

            foreach (WorkItem wi in eligible)
                _executionQueue.Enqueue(wi);

            _auditLedger.AddLast(new AuditLog($"Stage planned: {stage}"));
        }

        public void ExecuteNext()
        {
            if (_executionQueue.Count == 0)
                return;

            WorkItem workItem = _executionQueue.Dequeue();
            SDLCStage previousStage = workItem.Stage;

            workItem.Stage = workItem.Stage + 1;
            SDLCStage newStage = workItem.Stage;

            _stageBoard[previousStage].Remove(workItem);

            if (!_stageBoard.ContainsKey(newStage))
                _stageBoard[newStage] = new List<WorkItem>();

            _stageBoard[newStage].Add(workItem);

            _auditLedger.AddLast(
                new AuditLog($"Executed WorkItem {workItem.Id}: {previousStage} → {newStage}")
            );
        }

        public void RegisterTestSuite(string suiteId)
        {
            _uniqueTestSuites.Add(suiteId);
            _auditLedger.AddLast(new AuditLog($"Test suite registered: {suiteId}"));
        }

        public void DeployRelease(string version)
        {
            _rollbackStack.Push(new BuildSnapshot(version));
            _auditLedger.AddLast(new AuditLog($"Release deployed: {version}"));
        }

        public void RollbackRelease()
        {
            if (_rollbackStack.Count == 0)
                return;

            BuildSnapshot snapshot = _rollbackStack.Pop();
            _auditLedger.AddLast(
                new AuditLog($"Rollback executed for release: {snapshot.Version}")
            );
        }

        public void RecordQualityMetric(string metricName, double score)
        {
            if (_releaseScoreboard.ContainsKey(score))
                return;

            _releaseScoreboard.Add(score, new QualityMetric(metricName, score));
        }

        public void PrintAuditLedger()
        {
            foreach (AuditLog log in _auditLedger)
                Console.WriteLine($"{log.Time:u} - {log.Action}");
        }

        public void PrintReleaseScoreboard()
        {
            for (int i = _releaseScoreboard.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(
                    $"{_releaseScoreboard.Values[i].Name}: {_releaseScoreboard.Keys[i]:F2}"
                );
            }
        }
    }
}

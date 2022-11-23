using System;

namespace IntermediateCourseWorkflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            var video = new VideoUploader();
            var encode = new EncodeVideo();
            var call = new CallService();
            var mail = new SendEmail();
            var process = new Processing();

            workflow.Add(video);
            workflow.Add(encode);
            workflow.Add(call);
            workflow.Add(mail);
            workflow.Add(process);
            workflow.Remove(video);

            var engine = new WorkflowEngine();

            engine.Run(workflow);

        }
    }
}

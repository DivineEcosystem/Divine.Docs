# <a id="Divine_Update_UpdateSynchronizationContext"></a> Class UpdateSynchronizationContext

Namespace: [Divine.Update](Divine.Update.md)  
Assembly: Divine.dll  

```csharp
public sealed class UpdateSynchronizationContext : SynchronizationContext
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SynchronizationContext](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext) ← 
[UpdateSynchronizationContext](Divine.Update.UpdateSynchronizationContext.md)

#### Inherited Members

[SynchronizationContext.CreateCopy\(\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.createcopy), 
[SynchronizationContext.IsWaitNotificationRequired\(\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.iswaitnotificationrequired), 
[SynchronizationContext.OperationCompleted\(\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.operationcompleted), 
[SynchronizationContext.OperationStarted\(\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.operationstarted), 
[SynchronizationContext.Post\(SendOrPostCallback, object?\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.post), 
[SynchronizationContext.Send\(SendOrPostCallback, object?\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.send), 
[SynchronizationContext.SetSynchronizationContext\(SynchronizationContext?\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.setsynchronizationcontext), 
[SynchronizationContext.Wait\(nint\[\], bool, int\)](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.wait), 
[SynchronizationContext.Current](https://learn.microsoft.com/dotnet/api/system.threading.synchronizationcontext.current), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<UpdateSynchronizationContext\>\(UpdateSynchronizationContext, params UpdateSynchronizationContext\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Methods

### <a id="Divine_Update_UpdateSynchronizationContext_Post_System_Threading_SendOrPostCallback_System_Object_"></a> Post\(SendOrPostCallback, object?\)

When overridden in a derived class, dispatches an asynchronous message to a synchronization context.

```csharp
public override void Post(SendOrPostCallback d, object? state)
```

#### Parameters

`d` [SendOrPostCallback](https://learn.microsoft.com/dotnet/api/system.threading.sendorpostcallback)

The <xref href="System.Threading.SendOrPostCallback" data-throw-if-not-resolved="false"></xref> delegate to call.

`state` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The object passed to the delegate.


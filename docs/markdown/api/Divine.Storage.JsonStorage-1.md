# <a id="Divine_Storage_JsonStorage_1"></a> Class JsonStorage<T\>

Namespace: [Divine.Storage](Divine.Storage.md)  
Assembly: Divine.Common.dll  

```csharp
public abstract class JsonStorage<T> : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging, IDisposable where T : JsonStorage<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ObservableObject](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject) ← 
[JsonStorage<T\>](Divine.Storage.JsonStorage\-1.md)

#### Implements

[INotifyPropertyChanged](https://learn.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged), 
[INotifyPropertyChanging](https://learn.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanging), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[ObservableObject.OnPropertyChanged\(PropertyChangedEventArgs\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanged\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanged\(system\-componentmodel\-propertychangedeventargs\)), 
[ObservableObject.OnPropertyChanging\(PropertyChangingEventArgs\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanging\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanging\(system\-componentmodel\-propertychangingeventargs\)), 
[ObservableObject.OnPropertyChanged\(string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanged\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanged\(system\-string\)), 
[ObservableObject.OnPropertyChanging\(string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.onpropertychanging\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-onpropertychanging\(system\-string\)), 
[ObservableObject.SetProperty<T\>\(ref T, T, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0@\-0\-system\-string\)), 
[ObservableObject.SetProperty<T\>\(ref T, T, IEqualityComparer<T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0@\-0\-system\-collections\-generic\-iequalitycomparer\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetProperty<T\>\(T, T, Action<T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0\-0\-system\-action\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetProperty<T\>\(T, T, IEqualityComparer<T\>, Action<T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-1\(\-0\-0\-system\-collections\-generic\-iequalitycomparer\(\(\-0\)\)\-system\-action\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetProperty<TModel, T\>\(T, T, TModel, Action<TModel, T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-2\(\-1\-1\-0\-system\-action\(\(\-0\-1\)\)\-system\-string\)), 
[ObservableObject.SetProperty<TModel, T\>\(T, T, IEqualityComparer<T\>, TModel, Action<TModel, T\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setproperty\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setproperty\-2\(\-1\-1\-system\-collections\-generic\-iequalitycomparer\(\(\-1\)\)\-0\-system\-action\(\(\-0\-1\)\)\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion\(ref ObservableObject.TaskNotifier?, Task?, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier@\-system\-threading\-tasks\-task\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion\(ref ObservableObject.TaskNotifier?, Task?, Action<Task?\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier@\-system\-threading\-tasks\-task\-system\-action\(\(system\-threading\-tasks\-task\)\)\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion<T\>\(ref ObservableObject.TaskNotifier<T\>?, Task<T\>?, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\-1\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier\(\(\-0\)\)@\-system\-threading\-tasks\-task\(\(\-0\)\)\-system\-string\)), 
[ObservableObject.SetPropertyAndNotifyOnCompletion<T\>\(ref ObservableObject.TaskNotifier<T\>?, Task<T\>?, Action<Task<T\>?\>, string?\)](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.setpropertyandnotifyoncompletion\#communitytoolkit\-mvvm\-componentmodel\-observableobject\-setpropertyandnotifyoncompletion\-1\(communitytoolkit\-mvvm\-componentmodel\-observableobject\-tasknotifier\(\(\-0\)\)@\-system\-threading\-tasks\-task\(\(\-0\)\)\-system\-action\(\(system\-threading\-tasks\-task\(\(\-0\)\)\)\)\-system\-string\)), 
[ObservableObject.PropertyChanged](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.propertychanged), 
[ObservableObject.PropertyChanging](https://learn.microsoft.com/dotnet/api/communitytoolkit.mvvm.componentmodel.observableobject.propertychanging), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<JsonStorage<T\>\>\(JsonStorage<T\>, params JsonStorage<T\>\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Storage_JsonStorage_1__ctor"></a> JsonStorage\(\)

```csharp
protected JsonStorage()
```

## Properties

### <a id="Divine_Storage_JsonStorage_1_HasUnsavedChanges"></a> HasUnsavedChanges

```csharp
[JsonIgnore]
public bool HasUnsavedChanges { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Storage_JsonStorage_1_IsDebounceSavePending"></a> IsDebounceSavePending

```csharp
[JsonIgnore]
public bool IsDebounceSavePending { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Storage_JsonStorage_1_CancelDebouncedSave"></a> CancelDebouncedSave\(\)

```csharp
public void CancelDebouncedSave()
```

### <a id="Divine_Storage_JsonStorage_1_DebouncedSave_System_Boolean_System_Nullable_System_TimeSpan__"></a> DebouncedSave\(bool, TimeSpan?\)

```csharp
public void DebouncedSave(bool forceSave = false, TimeSpan? delay = null)
```

#### Parameters

`forceSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`delay` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan)?

### <a id="Divine_Storage_JsonStorage_1_Dispose"></a> Dispose\(\)

```csharp
public void Dispose()
```

### <a id="Divine_Storage_JsonStorage_1_Dispose_System_Boolean_"></a> Dispose\(bool\)

```csharp
protected virtual void Dispose(bool disposing)
```

#### Parameters

`disposing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Storage_JsonStorage_1_InitializeCore_System_IServiceProvider_"></a> InitializeCore\(IServiceProvider\)

```csharp
protected virtual void InitializeCore(IServiceProvider provider)
```

#### Parameters

`provider` [IServiceProvider](https://learn.microsoft.com/dotnet/api/system.iserviceprovider)

### <a id="Divine_Storage_JsonStorage_1_Load"></a> Load\(\)

```csharp
public void Load()
```

### <a id="Divine_Storage_JsonStorage_1_Save_System_Boolean_"></a> Save\(bool\)

```csharp
public void Save(bool forceSave = false)
```

#### Parameters

`forceSave` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Storage_JsonStorage_1_WaitForDebouncedSaveAsync_System_TimeSpan_System_Threading_CancellationToken_"></a> WaitForDebouncedSaveAsync\(TimeSpan, CancellationToken\)

```csharp
public Task WaitForDebouncedSaveAsync(TimeSpan timeout, CancellationToken cancellationToken = default)
```

#### Parameters

`timeout` [TimeSpan](https://learn.microsoft.com/dotnet/api/system.timespan)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)


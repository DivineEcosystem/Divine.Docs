# <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message"></a> Class C2S\_CONNECTION\_Message

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class C2S_CONNECTION_Message : IMessage<C2S_CONNECTION_Message>, IEquatable<C2S_CONNECTION_Message>, IDeepCloneable<C2S_CONNECTION_Message>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[C2S\_CONNECTION\_Message](Divine.Protobufs.Dota2.C2S\_CONNECTION\_Message.md)

#### Implements

IMessage<C2S\_CONNECTION\_Message\>, 
[IEquatable<C2S\_CONNECTION\_Message\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<C2S\_CONNECTION\_Message\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<C2S\_CONNECTION\_Message\>\(C2S\_CONNECTION\_Message, params C2S\_CONNECTION\_Message\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message__ctor"></a> C2S\_CONNECTION\_Message\(\)

```csharp
public C2S_CONNECTION_Message()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message__ctor_Divine_Protobufs_Dota2_C2S_CONNECTION_Message_"></a> C2S\_CONNECTION\_Message\(C2S\_CONNECTION\_Message\)

```csharp
public C2S_CONNECTION_Message(C2S_CONNECTION_Message other)
```

#### Parameters

`other` [C2S\_CONNECTION\_Message](Divine.Protobufs.Dota2.C2S\_CONNECTION\_Message.md)

## Fields

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_AddonNameFieldNumber"></a> AddonNameFieldNumber

```csharp
public const int AddonNameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_LocalhostSameProcessCheckFieldNumber"></a> LocalhostSameProcessCheckFieldNumber

```csharp
public const int LocalhostSameProcessCheckFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_AddonName"></a> AddonName

```csharp
public string AddonName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_HasAddonName"></a> HasAddonName

```csharp
public bool HasAddonName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_LocalhostSameProcessCheck"></a> LocalhostSameProcessCheck

```csharp
public C2S_CONNECT_SameProcessCheck LocalhostSameProcessCheck { get; set; }
```

#### Property Value

 [C2S\_CONNECT\_SameProcessCheck](Divine.Protobufs.Dota2.C2S\_CONNECT\_SameProcessCheck.md)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_Parser"></a> Parser

```csharp
public static MessageParser<C2S_CONNECTION_Message> Parser { get; }
```

#### Property Value

 MessageParser<[C2S\_CONNECTION\_Message](Divine.Protobufs.Dota2.C2S\_CONNECTION\_Message.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_ClearAddonName"></a> ClearAddonName\(\)

```csharp
public void ClearAddonName()
```

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_Clone"></a> Clone\(\)

```csharp
public C2S_CONNECTION_Message Clone()
```

#### Returns

 [C2S\_CONNECTION\_Message](Divine.Protobufs.Dota2.C2S\_CONNECTION\_Message.md)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_Equals_Divine_Protobufs_Dota2_C2S_CONNECTION_Message_"></a> Equals\(C2S\_CONNECTION\_Message\)

```csharp
public bool Equals(C2S_CONNECTION_Message other)
```

#### Parameters

`other` [C2S\_CONNECTION\_Message](Divine.Protobufs.Dota2.C2S\_CONNECTION\_Message.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_MergeFrom_Divine_Protobufs_Dota2_C2S_CONNECTION_Message_"></a> MergeFrom\(C2S\_CONNECTION\_Message\)

```csharp
public void MergeFrom(C2S_CONNECTION_Message other)
```

#### Parameters

`other` [C2S\_CONNECTION\_Message](Divine.Protobufs.Dota2.C2S\_CONNECTION\_Message.md)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_C2S_CONNECTION_Message_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

